using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class UserDAL : BaseDAL
        {
            public UserDAL(string connectionString) : base(connectionString)
            {
            }

            public List<UserDTO> ReadAllUsers()
            {
                List<UserDTO> users = new List<UserDTO>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserDTO user = new UserDTO(
                                id: (int)reader["UserID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                firstName: reader["FirstName"] as string,
                                lastName: reader["LastName"] as string,
                                settings: reader["Settings"] as string,
                                favoriteMovies: GetMoviesForUser((int)reader["UserID"], "FavoriteMovies"),
                                watchList: GetMoviesForUser((int)reader["UserID"], "WatchList")
 );
                                users.Add(user);
                            }
                        }
                    }
                }
                return users;
            }


            private List<MovieDTO> GetMoviesForUser(int userId, string tableName)
            {
                List<MovieDTO> movies = new List<MovieDTO>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT m.* FROM {tableName} as t JOIN Movie as m ON t.MovieId = m.MovieID WHERE t.UserId = @userId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MovieDTO movie = new MovieDTO
                                {
                                    Id = (int)reader["MovieID"],
                                    Title = reader["Title"] as string,
                                    ReleaseDate = (DateTime)reader["ReleaseDate"],
                                    Description = reader["Description"] as string,
                                    PosterImageURL = reader["PosterImageURL"] as string,
                                    TrailerURL = reader["TrailerURL"] as string,
                                    RuntimeMinutes = (int)reader["RuntimeMinutes"],
                                    AverageRating = (decimal)reader["AverageRating"]
                                };
                                movies.Add(movie);
                            }
                        }
                    }
                }
                return movies;
            }

            public void CreateUser(UserDTO user)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [User] (Username, Email, PasswordHash, FirstName, LastName, Settings) VALUES (@Username, @Email, @PasswordHash, @FirstName, @LastName, @Settings)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                        cmd.Parameters.AddWithValue("@Settings", user.Settings);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public UserDTO GetUserByUsername(string username)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM [User] WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserDTO(
                                    id: (int)reader["UserID"],
                                    username: reader["Username"] as string,
                                    email: reader["Email"] as string,
                                    passwordHash: reader["PasswordHash"] as string,
                                    firstName: reader["FirstName"] as string,
                                    lastName: reader["LastName"] as string,
                                    settings: reader["Settings"] as string,
                                    favoriteMovies: GetMoviesForUser((int)reader["UserID"], "FavoriteMovies"),
                                    watchList: GetMoviesForUser((int)reader["UserID"], "WatchList")
                                );
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }

            public void UpdateUser(UserDTO user)
            {
                throw new NotImplementedException();
            }

            public void DeleteUser(int userId)
            {
                throw new NotImplementedException();
            }
        }
    }
}
