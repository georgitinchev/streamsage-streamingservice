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

            public List<MovieDTO> ReadAllMovies()
            {
                string query = "SELECT ID, Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating FROM Movie";
                List<MovieDTO> movies = new List<MovieDTO>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MovieDTO movie = new MovieDTO
                                {
                                    Id = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    ReleaseDate = reader.GetDateTime(2),
                                    Description = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    PosterImageURL = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    TrailerURL = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    RuntimeMinutes = reader.GetInt32(6),
                                    AverageRating = reader.IsDBNull(7) ? null : reader.GetDecimal(7)
                                };
                                movies.Add(movie);
                            }


                        }
                    }
                }
                return movies;
            }
            public void UpdateMovie(MovieDTO movie)
            {
                string query = "UPDATE Movie SET Title = @Title, ReleaseDate = @ReleaseDate, Description = @Description, PosterImageURL = @PosterImageURL, TrailerURL = @TrailerURL, RuntimeMinutes = @RuntimeMinutes, AverageRating = @AverageRating WHERE ID = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
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
                }
            }

            public void DeleteMovie(int movieId)
            {
                string deleteMovieQuery = "DELETE FROM Movie WHERE ID = @Id";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteMovieQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", movieId);
                            command.ExecuteNonQuery();
                        }
                    }
                    ReseedIdentityColumn("Movie", movieId);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting movie: " + ex.Message);
                }
            }


            // Reseed id of deleted movie
            private void ReseedIdentityColumn(string tableName, int seedValue)
            {
                try
                {
                    string reseedQuery = $"DBCC CHECKIDENT ('{tableName}', RESEED, {seedValue})";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(reseedQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error reseeding identity column: " + ex.Message);
                }
            }


            public void CreateMovie(MovieDTO movie)
            {
                string query = "INSERT INTO Movie (Title, ReleaseDate, Description, PosterImageURL, TrailerURL, RuntimeMinutes, AverageRating) VALUES (@Title, @ReleaseDate, @Description, @PosterImageURL, @TrailerURL, @RuntimeMinutes, NULL)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", movie.Title);
                        command.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                        command.Parameters.AddWithValue("@Description", movie.Description);
                        command.Parameters.AddWithValue("@PosterImageURL", movie.PosterImageURL);
                        command.Parameters.AddWithValue("@TrailerURL", movie.TrailerURL);
                        command.Parameters.AddWithValue("@RuntimeMinutes", movie.RuntimeMinutes);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public MovieDTO GetMovie(int movieId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
