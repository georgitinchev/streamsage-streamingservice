using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class MovieDAL : BaseDAL
        {

            public MovieDAL(string connectionString) : base(connectionString)
            {
            }

            // Method to read all movies
            public List<MovieDTO> ReadAllMovies()
            {
                var movies = new List<MovieDTO>();
                var movieQuery = "SELECT ID, Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating FROM Movie";
                var genreQuery = "SELECT mg.MovieID, g.Name FROM MovieGenre mg INNER JOIN Genre g ON mg.GenreID = g.ID";
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(movieQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movies.Add(new MovieDTO
                                {
                                    Id = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    ReleaseDate = reader.GetDateTime(2),
                                    Description = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    PosterImageURL = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    TrailerURL = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    RuntimeMinutes = reader.GetInt32(6),
                                    AverageRating = reader.IsDBNull(7) ? null : reader.GetDecimal(7),
                                    Genres = new List<string>()
                                });
                            }
                        }
                    }
                    using (var command = new SqlCommand(genreQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int movieId = reader.GetInt32(0);
                                string genreName = reader.GetString(1);
                                var movie = movies.FirstOrDefault(m => m.Id == movieId);
                                movie?.Genres.Add(genreName);
                            }
                        }
                    }
                }
                return movies;
            }

            // Method to update a movie
            public void UpdateMovie(MovieDTO movie)
            {
                string query = "UPDATE Movie SET Title = @Title, ReleaseDate = @ReleaseDate, Description = @Description, PosterImageURL = @PosterImageURL, TrailerURL = @TrailerURL, RuntimeMinutes = @RuntimeMinutes, AverageRating = @AverageRating WHERE ID = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
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
                            }

                            ClearMovieGenres(movie.Id, connection, transaction);
                            InsertMovieGenres(movie.Id, movie.Genres, connection, transaction);

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Transaction failed: " + ex.Message);
                        }
                    }
                }
            }


            // Method to delete a movie
            public void DeleteMovie(int movieId)
            {
                string deleteMovieQuery = "DELETE FROM Movie WHERE ID = @Id";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            ClearMovieGenres(movieId, connection, transaction);
                            using (SqlCommand command = new SqlCommand(deleteMovieQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", movieId);
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting movie: " + ex.Message);
                }
            }


            // Method to create a movie
            public void CreateMovie(MovieDTO movie)
            {
                string query = "INSERT INTO Movie (Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating) OUTPUT INSERTED.ID VALUES (@Title, @ReleaseDate, @Description, @PosterImageURL, @TrailerURL, @RuntimeMinutes, NULL)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction()) 
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction)) 
                        {
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
                    }
                }
            }

            // Method to insert genres for a movie
            private void InsertMovieGenres(int movieId, List<string> genres, SqlConnection connection, SqlTransaction transaction)
            {
                foreach (var genreName in genres)
                {
                    int genreId = GetGenreIdByName(genreName, connection, transaction); // Ensure GetGenreIdByName also supports transactions
                    string insertQuery = "INSERT INTO MovieGenre (MovieID, GenreID) VALUES (@MovieID, @GenreID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
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
                using (SqlCommand command = new SqlCommand(deleteQuery, connection, transaction))
                {
                    command.Parameters.AddWithValue("@MovieID", movieId);
                    command.ExecuteNonQuery();
                }
            }

            // Method to query genre ID by name with transaction support
            private int GetGenreIdByName(string genreName, SqlConnection connection, SqlTransaction transaction)
            {
                string query = "SELECT ID FROM Genre WHERE Name = @GenreName";
                using (SqlCommand command = new SqlCommand(query, connection, transaction)) 
                {
                    command.Parameters.AddWithValue("@GenreName", genreName);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        throw new Exception($"Genre not found: {genreName}");
                    }
                }
            }


            // Method to get all movie genres
            public List<string> GetAllGenres()
            {
                List<string> genres = new List<string>();
                string query = "SELECT Name FROM Genre";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                genres.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                return genres;
            }
            public MovieDTO GetMovie(int movieId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
