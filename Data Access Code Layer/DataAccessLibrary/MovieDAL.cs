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

			public void CreateMovie(MovieDTO movie)
            {
                throw new NotImplementedException();
            }

            public MovieDTO ReadMovie(int movieId)
            {
                throw new NotImplementedException();
            }

            public void UpdateMovie(MovieDTO movie)
            {
                throw new NotImplementedException();
            }

            public void DeleteMovie(int movieId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
