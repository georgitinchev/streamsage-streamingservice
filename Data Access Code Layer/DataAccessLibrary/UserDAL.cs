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
                                id: (int)reader["ID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                firstName: reader["FirstName"] as string,
                                lastName: reader["LastName"] as string,
                                profilePicture: reader["ProfilePictureURL"] as string,
                                settings: reader["Settings"] as string,
                                favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                watchList: GetMoviesForUser((int)reader["ID"], "Watchlist")
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
                    string query = $"SELECT m.* FROM {tableName} as t JOIN Movie as m ON t.MovieId = m.ID WHERE t.UserId = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MovieDTO movie = new MovieDTO
                                {
                                    Id = (int)reader["ID"],
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
                    string query = "INSERT INTO [User] (Username, Email, PasswordHash, FirstName, LastName, ProfilePictureURL, Settings) VALUES (@Username, @Email, @PasswordHash, @FirstName, @LastName, @ProfilePictureURL, @Settings)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                        cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL);
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
                                    id: (int)reader["ID"],
                                    username: reader["Username"] as string,
                                    email: reader["Email"] as string,
                                    passwordHash: reader["PasswordHash"] as string,
                                    firstName: reader["FirstName"] as string,
                                    lastName: reader["LastName"] as string,
                                    profilePicture: reader["ProfilePictureURL"] as string,
                                    settings: reader["Settings"] as string,
                                    favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                    watchList: GetMoviesForUser((int)reader["ID"], "Watchlist")
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

            public void ChangePassword(string username, string newPassword)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE [User] SET PasswordHash = @PasswordHash WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PasswordHash", newPassword);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void UpdateUser(UserDTO user)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE [User] SET Username = @Username, Email = @Email, FirstName = @FirstName, LastName = @LastName, ProfilePictureURL = @ProfilePictureURL, Settings = @Settings WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                        cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL);
                        cmd.Parameters.AddWithValue("@Settings", user.Settings);
                        cmd.Parameters.AddWithValue("@ID", user.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteUser(int userId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM [User] WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
