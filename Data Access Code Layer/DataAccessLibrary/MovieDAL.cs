using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccessLibrary
{
    public class MovieDAL : BaseDAL, IMovieDAL
    {
        public MovieDAL() : base() { }

        // Method to read all movies
        public List<MovieDTO> ReadAllMovies()
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
                                runtimeMinutes: reader.GetInt32(6),
                                averageRating: reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                                genres: new List<string> { reader.GetString(8) },
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

        // Method to update a movie
        public void UpdateMovie(MovieDTO movie)
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
                        throw new System.Exception("Transaction failed: " + ex.Message);
                    }
                }
            }
        }

        // Method to delete a movie
        public void DeleteMovie(int movieId)
        {
            string deleteMovieQuery = "DELETE FROM Movie WHERE ID = @Id";

            using (var connection = CreateConnection())
            using (var command = new SqlCommand(deleteMovieQuery, connection))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@Id", movieId);
                        command.ExecuteNonQuery();

                        ClearMovieGenres(movieId, connection, transaction);

                        transaction.Commit();
                    }
                    catch (System.Exception ex)
                    {
                        transaction.Rollback();
                        throw new System.Exception("Error deleting movie: " + ex.Message);
                    }
                }
            }
        }

        // Method to create a movie
        public void CreateMovie(MovieDTO movie)
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
                        throw new System.Exception("Error creating movie: " + ex.Message);
                    }
                }
            }
        }

        // Method to insert genres for a movie
        private void InsertMovieGenres(int movieId, List<string> genres, SqlConnection connection, SqlTransaction transaction)
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
        // Method to clear all genres for a movie
        private void ClearMovieGenres(int movieId, SqlConnection connection, SqlTransaction transaction)
        {
            string deleteQuery = "DELETE FROM MovieGenre WHERE MovieID = @MovieID";
            using (var command = new SqlCommand(deleteQuery, connection, transaction))
            {
                command.Parameters.AddWithValue("@MovieID", movieId);
                command.ExecuteNonQuery();
            }
        }

        // Method to query genre ID by name with transaction support
        private int GetGenreIdByName(string genreName, SqlConnection connection, SqlTransaction transaction)
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

        // Method to get all movie genres
        public List<string> GetAllGenres()
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

        // Method to get a specific movie by its ID
        public MovieDTO GetMovie(int movieId)
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
                                genres: new List<string> { reader.GetString(8) },
                                directors: new List<string>(),
                                actors: new List<string>()
                            );
                        }
                        else
                        {
                            movie.Genres.Add(reader.GetString(8));
                            if (!reader.IsDBNull(9) && !movie.Directors.Contains(reader.GetString(9)))
                                movie.Directors.Add(reader.GetString(9));
                            if (!reader.IsDBNull(10) && !movie.Actors.Contains(reader.GetString(10)))
                                movie.Actors.Add(reader.GetString(10));
                        }
                    }
                    return movie;
                }
            }
        }
    }
}
