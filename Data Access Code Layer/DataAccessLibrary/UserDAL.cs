using DTOs;
using Microsoft.Data.SqlClient;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class UserDAL : BaseDAL, IUserDAL
        {
            public UserDAL() : base()
            {
            }

            public List<UserDTO> ReadAllUsers()
            {
                List<UserDTO> users = new List<UserDTO>();
                using (SqlConnection conn = new SqlConnection())
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
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    string movieQuery = $"SELECT m.* FROM {tableName} as t JOIN Movie as m ON t.MovieId = m.ID WHERE t.UserId = @ID";
                    string genreQuery = "SELECT mg.MovieID, g.Name FROM MovieGenre mg INNER JOIN Genre g ON mg.GenreID = g.ID WHERE mg.MovieID = @MovieID";

                    using (SqlCommand cmd = new SqlCommand(movieQuery, conn))
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
                                    AverageRating = reader["AverageRating"] == DBNull.Value ? (decimal?)null : (decimal)reader["AverageRating"],
                                    Genres = new List<string>()
                                };
                                movies.Add(movie);
                            }
                        }
                    }

                    foreach (var movie in movies)
                    {
                        using (SqlCommand genreCmd = new SqlCommand(genreQuery, conn))
                        {
                            genreCmd.Parameters.AddWithValue("@MovieID", movie.Id);
                            using (SqlDataReader genreReader = genreCmd.ExecuteReader())
                            {
                                while (genreReader.Read())
                                {
                                    string genreName = genreReader.GetString(1);
                                    movie?.Genres.Add(genreName);
                                }
                            }
                        }
                    }
                }
                return movies;
            }


            public void CreateUser(UserDTO user)
            {
                using (SqlConnection conn = new SqlConnection())
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
                using (SqlConnection conn = new SqlConnection())
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
                using (SqlConnection conn = new SqlConnection())
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
                using (SqlConnection conn = new SqlConnection())
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
                using (SqlConnection conn = new SqlConnection())
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
