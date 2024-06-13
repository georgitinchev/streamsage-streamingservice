using DataAccessLibrary.Exception;
using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace DataAccessLibrary
{
    public class MovieDAL : BaseDAL, IMovieDAL
    {
        public MovieDAL() : base() { }

        // Method to read all movies
        public List<MovieDTO> ReadAllMovies()
        {
            try
            {
                var movies = new List<MovieDTO>();

                var movieQuery = @"
         SELECT 
        m.ID, m.Title, m.ReleaseDate, m.Description, m.PosterImageURL, m.TrailerURL, 
        m.RuntimeMinutes, m.AverageRating, 
        g.Name AS GenreName,
        d.Name AS DirectorName,
        a.Name AS ActorName
        FROM Movie m
        LEFT JOIN MovieGenre mg ON m.ID = mg.MovieID
        LEFT JOIN Genre g ON mg.GenreID = g.ID
        LEFT JOIN MovieDirector md ON m.ID = md.MovieID
        LEFT JOIN Director d ON md.DirectorID = d.ID
        LEFT JOIN MovieActor ma ON m.ID = ma.MovieID
        LEFT JOIN Actor a ON ma.ActorID = a.ID";

                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(movieQuery, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int movieId = reader.GetInt32(0);
                            var existingMovie = movies.Find(m => m.Id == movieId);
                            if (existingMovie == null)
                            {
                                var movie = new MovieDTO(
                                    id: movieId,
                                    title: reader.GetString(1),
                                    releaseDate: reader.GetDateTime(2),
                                    description: reader.IsDBNull(3) ? null : reader.GetString(3),
                                    posterImageURL: reader.IsDBNull(4) ? null : reader.GetString(4),
                                    trailerURL: reader.IsDBNull(5) ? null : reader.GetString(5),
                                    runtimeMinutes: reader.IsDBNull(6) ? 0 : reader.GetInt32(6), 
                                    averageRating: reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                                    genres: reader.IsDBNull(8) ? new List<string>() : new List<string> { reader.GetString(8) },
                                    directors: new List<string>(),
                                    actors: new List<string>()
                                );
                                if (!reader.IsDBNull(9))
                                    movie.Directors.Add(reader.GetString(9));
                                if (!reader.IsDBNull(10))
                                    movie.Actors.Add(reader.GetString(10));
                                movies.Add(movie);
                            }
                            else
                            {
                                if (!reader.IsDBNull(8))
                                    existingMovie.Genres.Add(reader.GetString(8));
                                if (!reader.IsDBNull(9) && !existingMovie.Directors.Contains(reader.GetString(9)))
                                    existingMovie.Directors.Add(reader.GetString(9));
                                if (!reader.IsDBNull(10) && !existingMovie.Actors.Contains(reader.GetString(10)))
                                    existingMovie.Actors.Add(reader.GetString(10));
                            }
                        }
                    }
                }
                return movies;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while reading all movies.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while reading all movies. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while reading all movies.", ex);
            }
        }

        // Method to update a movie
        public void UpdateMovie(MovieDTO movie)
        {
            try
            {
                string query = @"
                UPDATE Movie 
                SET Title = @Title, ReleaseDate = @ReleaseDate, Description = @Description, 
                    PosterImageURL = @PosterImageURL, TrailerURL = @TrailerURL, 
                    RuntimeMinutes = @RuntimeMinutes, AverageRating = @AverageRating 
                WHERE ID = @Id";

                using (var connection = CreateConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@Id", movie.Id);
                            command.Parameters.AddWithValue("@Title", movie.Title);
                            command.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                            command.Parameters.AddWithValue("@Description", movie.Description);
                            command.Parameters.AddWithValue("@PosterImageURL", movie.PosterImageURL);
                            command.Parameters.AddWithValue("@TrailerURL", movie.TrailerURL);
                            command.Parameters.AddWithValue("@RuntimeMinutes", movie.RuntimeMinutes);
                            command.Parameters.Add("@AverageRating", SqlDbType.Decimal);
                            command.Parameters["@AverageRating"].Value = movie.AverageRating.HasValue ? (object)movie.AverageRating.Value : DBNull.Value;
                            command.ExecuteNonQuery();

                            ClearMovieGenres(movie.Id, connection, transaction);
                            InsertMovieGenres(movie.Id, movie.Genres, connection, transaction);

                            transaction.Commit();
                        }
                        catch (System.Exception ex)
                        {
                            transaction.Rollback();
                            throw new DataAccessException("Transaction failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException($"A database error occurred while updating the movie with ID {movie.Id}.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException($"An error occurred while updating the movie with ID {movie.Id}. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException($"An unexpected error occurred while updating the movie with ID {movie.Id}.", ex);
            }
        }

        // Method to delete a movie
        public void DeleteMovie(int movieId)
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("DELETE FROM MovieGenre WHERE MovieID = @MovieID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MovieID", movieId);
                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand("DELETE FROM MovieDirector WHERE MovieID = @MovieID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MovieID", movieId);
                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand("DELETE FROM MovieActor WHERE MovieID = @MovieID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MovieID", movieId);
                                command.ExecuteNonQuery();
                            }

                            using (SqlCommand command = new SqlCommand("DELETE FROM Movie WHERE ID = @MovieID", connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MovieID", movieId);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch(SqlException ex)
                        {
                            transaction.Rollback();
                            throw new DataAccessException($"Error deleting movie with ID {movieId}: {ex.Message}", ex);
                        }
                        catch (DataAccessException ex)
                        {
                            transaction.Rollback();
                            throw new DataAccessException($"Error deleting movie with ID {movieId}: {ex.Message}", ex);
                        }
                        catch (System.Exception ex)
                        {
                            transaction.Rollback();
                            throw new DataAccessException($"Error deleting movie with ID {movieId}: {ex.Message}", ex);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException($"A database error occurred while deleting the movie with ID {movieId}.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException($"An error occurred while deleting the movie with ID {movieId}. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException($"An unexpected error occurred while deleting the movie with ID {movieId}.", ex);
            }
        }


        // Method to create a movie
        public void CreateMovie(MovieDTO movie)
        {
            try
            {
                string query = @"
                INSERT INTO Movie (Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating) 
                OUTPUT INSERTED.ID 
                VALUES (@Title, @ReleaseDate, @Description, @PosterImageURL, @TrailerURL, @RuntimeMinutes, NULL)";

                using (var connection = CreateConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            command.Transaction = transaction;
                            command.Parameters.AddWithValue("@Title", movie.Title);
                            command.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                            command.Parameters.AddWithValue("@Description", movie.Description);
                            command.Parameters.AddWithValue("@PosterImageURL", movie.PosterImageURL);
                            command.Parameters.AddWithValue("@TrailerURL", movie.TrailerURL);
                            command.Parameters.AddWithValue("@RuntimeMinutes", movie.RuntimeMinutes);

                            int movieId = (int)command.ExecuteScalar();
                            if (movie.Genres != null && movie.Genres.Count > 0)
                            {
                                InsertMovieGenres(movieId, movie.Genres, connection, transaction);
                            }

                            transaction.Commit();
                        }
                        catch (System.Exception ex)
                        {
                            transaction.Rollback();
                            throw new DataAccessException("Error creating movie: " + ex.Message);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while creating a movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while creating a movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while creating a movie.", ex);
            }
        }


        // Method to insert genres for a movie
        private void InsertMovieGenres(int movieId, List<string> genres, SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                foreach (var genreName in genres)
                {
                    int genreId = GetGenreIdByName(genreName, connection, transaction);
                    string insertQuery = "INSERT INTO MovieGenre (MovieID, GenreID) VALUES (@MovieID, @GenreID)";
                    using (var command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@MovieID", movieId);
                        command.Parameters.AddWithValue("@GenreID", genreId);
                        command.ExecuteNonQuery();
                    }
                }
            } 
            catch (DataAccessException ex)
            {
                throw new DataAccessException("Error inserting genres for movie: " + ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while inserting genres for movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while inserting genres for movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while inserting genres for movie.", ex);
            }
        }
        // Method to clear all genres for a movie
        private void ClearMovieGenres(int movieId, SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                string deleteQuery = "DELETE FROM MovieGenre WHERE MovieID = @MovieID";
                using (var command = new SqlCommand(deleteQuery, connection, transaction))
                {
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.ExecuteNonQuery();
                }
            } 
            catch (DataAccessException ex)
            {
                throw new DataAccessException("Error deleting genres for movie: " + ex.Message, ex);
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while deleting genres for movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while deleting genres for movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while deleting genres for movie.", ex);
            }
        }

        // Method to query genre ID by name with transaction support
        private int GetGenreIdByName(string genreName, SqlConnection connection, SqlTransaction transaction)
        {
            try
            {
                string query = "SELECT ID FROM Genre WHERE Name = @GenreName";
                using (var command = new SqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@GenreName", genreName);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        throw new System.Exception($"Genre not found: {genreName}");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while getting genre ID by name.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while getting genre ID by name. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while getting genre ID by name.", ex);
            }
        }

        // Method to get all movie genres
        public List<string> GetAllGenres()
        {
            try
            {
                List<string> genres = new List<string>();
                string query = "SELECT Name FROM Genre";
                using (var connection = CreateConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genres.Add(reader.GetString(0));
                        }
                    }
                }
                return genres;
            } 
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while reading all genres.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while reading all genres. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while reading all genres.", ex);
            }
        }

        // Method to get a specific movie by its ID
        public MovieDTO GetMovie(int movieId)
        {
            try
            {
                string query = @"
        SELECT 
            m.ID, m.Title, m.ReleaseDate, m.Description, m.PosterImageURL, m.TrailerURL, 
            m.RuntimeMinutes, m.AverageRating, 
            g.Name AS GenreName,
            d.Name AS DirectorName,
            a.Name AS ActorName
        FROM Movie m
        LEFT JOIN MovieGenre mg ON m.ID = mg.MovieID
        LEFT JOIN Genre g ON mg.GenreID = g.ID
        LEFT JOIN MovieDirector md ON m.ID = md.MovieID
        LEFT JOIN Director d ON md.DirectorID = d.ID
        LEFT JOIN MovieActor ma ON m.ID = ma.MovieID
        LEFT JOIN Actor a ON ma.ActorID = a.ID
        WHERE m.ID = @Id";

                using (var connection = CreateConnection())
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", movieId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        MovieDTO movie = null;
                        while (reader.Read())
                        {
                            if (movie == null)
                            {
                                movie = new MovieDTO(
                                    id: reader.GetInt32(0),
                                    title: reader.GetString(1),
                                    releaseDate: reader.GetDateTime(2),
                                    description: reader.IsDBNull(3) ? null : reader.GetString(3),
                                    posterImageURL: reader.IsDBNull(4) ? null : reader.GetString(4),
                                    trailerURL: reader.IsDBNull(5) ? null : reader.GetString(5),
                                    runtimeMinutes: reader.GetInt32(6),
                                    averageRating: reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                                    genres: new List<string>(),
                                    directors: new List<string>(),
                                    actors: new List<string>()
                                );
                            }
                            if (!reader.IsDBNull(8) && !movie.Genres.Contains(reader.GetString(8)))
                                movie.Genres.Add(reader.GetString(8));
                            if (!reader.IsDBNull(9) && !movie.Directors.Contains(reader.GetString(9)))
                                movie.Directors.Add(reader.GetString(9));
                            if (!reader.IsDBNull(10) && !movie.Actors.Contains(reader.GetString(10)))
                                movie.Actors.Add(reader.GetString(10));
                        }
                        return movie;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException($"A database error occurred while reading the movie with ID {movieId}.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException($"An error occurred while reading the movie with ID {movieId}. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException($"An unexpected error occurred while reading the movie with ID {movieId}.", ex);
            }
        }
        // Fetch actors, directors and genres for list of movies.
        private void FetchRelatedData(List<MovieDTO> movies)
        {
            try
            {
                var movieIds = movies.Select(m => m.Id).ToArray();
                var movieIdsParam = string.Join(",", movieIds);

                var genreQuery = $@"
            SELECT 
            mg.MovieID, g.Name
            FROM MovieGenre mg
            JOIN Genre g ON mg.GenreID = g.ID
            WHERE mg.MovieID IN ({movieIdsParam})";

                var directorQuery = $@"
            SELECT 
            md.MovieID, d.Name
            FROM MovieDirector md
            JOIN Director d ON md.DirectorID = d.ID
            WHERE md.MovieID IN ({movieIdsParam})";

                var actorQuery = $@"
            SELECT 
            ma.MovieID, a.Name
            FROM MovieActor ma
            JOIN Actor a ON ma.ActorID = a.ID
            WHERE ma.MovieID IN ({movieIdsParam})";

                using (var connection = CreateConnection())
                {
                    connection.Open();

                    using (var genreCommand = new SqlCommand(genreQuery, connection))
                    {
                        using (var reader = genreCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32(0);
                                string genre = reader.GetString(1);
                                var movie = movies.Find(m => m.Id == movieId);
                                if (movie != null)
                                {
                                    movie.Genres.Add(genre);
                                }
                            }
                        }

                    }

                    using (var directorCommand = new SqlCommand(directorQuery, connection))
                    {
                        using (var reader = directorCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32(0);
                                string director = reader.GetString(1);
                                var movie = movies.Find(m => m.Id == movieId);
                                if (movie != null)
                                {
                                    movie.Directors.Add(director);
                                }
                            }
                        }
                    }

                    using (var actorCommand = new SqlCommand(actorQuery, connection))
                    {
                        using (var reader = actorCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32(0);
                                string actor = reader.GetString(1);
                                var movie = movies.Find(m => m.Id == movieId);
                                if (movie != null)
                                {
                                    movie.Actors.Add(actor);
                                }
                            }
                        }
                    }
                }
            } 
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while fetching related data for movies.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while fetching related data for movies. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while fetching related data for movies.", ex);
            }
        }


        public List<MovieDTO> GetMoviesPage(int pageNumber, int pageSize)
        {
            try
            {
                var movies = new List<MovieDTO>();
                var movieQuery = @"
        WITH MoviePage AS (
            SELECT 
                m.ID, m.Title, m.ReleaseDate, m.Description, m.PosterImageURL, m.TrailerURL, 
                m.RuntimeMinutes, m.AverageRating,
                ROW_NUMBER() OVER (ORDER BY m.ID) AS RowNum
            FROM Movie m
        )
        SELECT 
            mp.ID, mp.Title, mp.ReleaseDate, mp.Description, mp.PosterImageURL, mp.TrailerURL, 
            mp.RuntimeMinutes, mp.AverageRating
        FROM MoviePage mp
        WHERE mp.RowNum BETWEEN @StartRow AND @EndRow
        ORDER BY mp.ID";

                int startRow = (pageNumber - 1) * pageSize + 1;
                int endRow = pageNumber * pageSize;

                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(movieQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StartRow", startRow);
                        command.Parameters.AddWithValue("@EndRow", endRow);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new MovieDTO(
                                    id: reader.GetInt32(0),
                                    title: reader.GetString(1),
                                    releaseDate: reader.GetDateTime(2),
                                    description: reader.IsDBNull(3) ? null : reader.GetString(3),
                                    posterImageURL: reader.IsDBNull(4) ? null : reader.GetString(4),
                                    trailerURL: reader.IsDBNull(5) ? null : reader.GetString(5),
                                    runtimeMinutes: reader.GetInt32(6),
                                    averageRating: reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                                    genres: new List<string>(),
                                    directors: new List<string>(),
                                    actors: new List<string>()
                                );
                                movies.Add(movie);
                            }
                        }
                    }
                }
                if (movies.Any())
                {
                    FetchRelatedData(movies);
                }
                return movies;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while reading movies page.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while reading movies page. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while reading movies page.", ex);
            }
        }

        public bool MovieExists(int movieId)
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Movie WHERE ID = @MovieId", connection))
                    {
                        command.Parameters.AddWithValue("@MovieId", movieId);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while checking if a movie exists.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while checking if a movie exists. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while checking if a movie exists.", ex);
            }
        }

        // Get total movies integer method
        public int GetTotalMovies()
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Movie", connection))
                    {
                        return (int)command.ExecuteScalar();
                    }
                }
            } 
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while getting the total number of movies.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while getting the total number of movies. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while getting the total number of movies.", ex);
            }
        }

        // Method to add a genre to a movie
        public void AddGenreToMovie(int movieId, string genreName)
        {
            try
            {
                int genreId = InsertGenreAndGetId(genreName); 
                using (var connection = CreateConnection())
                using (var command = new SqlCommand("INSERT INTO MovieGenre (MovieID, GenreID) VALUES (@MovieID, @GenreID)", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.Parameters.AddWithValue("@GenreID", genreId);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while adding a genre to a movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while adding a genre to a movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while adding a genre to a movie.", ex);
            }
        }

        private int InsertGenreAndGetId(string genreName)
        {
            int genreId;
            using (var connection = CreateConnection())
            using (var command = new SqlCommand("INSERT INTO Genre (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@Name", genreName);
                connection.Open();
                genreId = Convert.ToInt32(command.ExecuteScalar());
            }
            return genreId;
        }




        // Method to add an actor to a movie
        public void AddActorToMovie(int movieId, string actorName)
        {
            try
            {
                int actorId = InsertActorAndGetId(actorName); 
                using (var connection = CreateConnection())
                using (var command = new SqlCommand("INSERT INTO MovieActor (MovieID, ActorID) VALUES (@MovieID, @ActorID)", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.Parameters.AddWithValue("@ActorID", actorId);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while adding an actor to a movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while adding an actor to a movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while adding an actor to a movie.", ex);
            }
        }

        private int InsertActorAndGetId(string actorName)
        {
            int actorId;
            using (var connection = CreateConnection())
            using (var command = new SqlCommand("INSERT INTO Actor (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@Name", actorName);
                connection.Open();
                actorId = Convert.ToInt32(command.ExecuteScalar());
            }
            return actorId;
        }

        // Method to add a director to a movie
        public void AddDirectorToMovie(int movieId, string directorName)
        {
            try
            {
                int directorId = InsertDirectorAndGetId(directorName); 
                using (var connection = CreateConnection())
                using (var command = new SqlCommand("INSERT INTO MovieDirector (MovieID, DirectorID) VALUES (@MovieID, @DirectorID)", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.Parameters.AddWithValue("@DirectorID", directorId);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException("A database error occurred while adding a director to a movie.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException("An error occurred while adding a director to a movie. The operation is not valid due to the current state of the object.", ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("An unexpected error occurred while adding a director to a movie.", ex);
            }
        }

        private int InsertDirectorAndGetId(string directorName)
        {
            int directorId;
            using (var connection = CreateConnection())
            using (var command = new SqlCommand("INSERT INTO Director (Name) VALUES (@Name); SELECT SCOPE_IDENTITY();", connection))
            {
                command.Parameters.AddWithValue("@Name", directorName);
                connection.Open();
                directorId = Convert.ToInt32(command.ExecuteScalar());
            }
            return directorId;
        }
    }
}
