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
				string query = "SELECT * FROM Movie";
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
								MovieDTO movie = new MovieDTO();
								movie.Id = reader.GetInt32(0);
								movie.Title = reader.GetString(1);
								movie.Year = reader.GetDateTime(2);
								movie.Description = reader.GetString(3);
								movie.PosterImageURL = reader.GetString(4);
								movie.TrailerURL = reader.GetString(5);
								movie.RuntimeMinutes = reader.GetInt32(6);
								movie.AverageRating = reader.GetDecimal(7);
								movies.Add(movie);
							}
						}
					}
				}
				return movies;
			}
            public void UpdateMovie(MovieDTO movie)
            {
                string query = "UPDATE Movie SET Title = @Title, Year = @Year, Description = @Description, PosterImageURL = @PosterImageURL, TrailerURL = @TrailerURL, RuntimeMinutes = @RuntimeMinutes WHERE Id = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", movie.Id);
                        command.Parameters.AddWithValue("@Title", movie.Title);
                        command.Parameters.AddWithValue("@Year", movie.Year);
                        command.Parameters.AddWithValue("@Description", movie.Description);
                        command.Parameters.AddWithValue("@PosterImageURL", movie.PosterImageURL);
                        command.Parameters.AddWithValue("@TrailerURL", movie.TrailerURL);
                        command.Parameters.AddWithValue("@RuntimeMinutes", movie.RuntimeMinutes);
                        command.ExecuteNonQuery();
                    }
                }
            }


            public void DeleteMovie(int movieId)
            {
                throw new NotImplementedException();
            }

            public void CreateMovie(MovieDTO movie)
            {
                throw new NotImplementedException();
            }

            public MovieDTO GetMovie(int movieId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
