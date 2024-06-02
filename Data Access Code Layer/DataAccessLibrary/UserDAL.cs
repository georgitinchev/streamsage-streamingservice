using DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

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
            using (SqlConnection conn = CreateConnection())
            {
                string query = "SELECT * FROM [User]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDTO user = new UserDTO(
                                id: (int)reader["ID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                passwordSalt: reader["PasswordSalt"] as string,
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

        public void CreateUser(UserDTO user)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "INSERT INTO [User] (Username, Email, PasswordHash, FirstName, LastName, ProfilePictureURL, Settings, PasswordSalt) " +
                               "VALUES (@Username, @Email, @PasswordHash, @FirstName, @LastName, @ProfilePictureURL, @Settings, @PasswordSalt)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Settings", user.Settings ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PasswordSalt", user.PasswordSalt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public UserDTO? GetUserByUsername(string username)
        {
            UserDTO? user = null;
            using (SqlConnection conn = CreateConnection())
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
                            user = new UserDTO(
                                id: (int)reader["ID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                passwordSalt: reader["PasswordSalt"] as string,
                                firstName: reader["FirstName"] as string,
                                lastName: reader["LastName"] as string,
                                profilePicture: reader["ProfilePictureURL"] as string,
                                settings: reader["Settings"] as string,
                                favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                watchList: GetMoviesForUser((int)reader["ID"], "Watchlist")
                            );
                        }
                    }
                }
            }
            return user;
        }

        public UserDTO? GetUserById(int userId)
        {
            UserDTO? user = null;
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "SELECT * FROM [User] WHERE ID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserDTO(
                                id: (int)reader["ID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                passwordSalt: reader["PasswordSalt"] as string,
                                firstName: reader["FirstName"] as string,
                                lastName: reader["LastName"] as string,
                                profilePicture: reader["ProfilePictureURL"] as string,
                                settings: reader["Settings"] as string,
                                favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                watchList: GetMoviesForUser((int)reader["ID"], "Watchlist")
                            );
                        }
                    }
                }
            }
            return user;
        }

        public void UpdateUser(UserDTO user)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "UPDATE [User] SET Username = @Username, Email = @Email, PasswordHash = @PasswordHash, " +
                               "FirstName = @FirstName, LastName = @LastName, ProfilePictureURL = @ProfilePictureURL, " +
                               "Settings = @Settings, PasswordSalt = @PasswordSalt WHERE ID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Settings", user.Settings ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PasswordSalt", user.PasswordSalt);
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM [User] WHERE ID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ChangePassword(int userId, string newPasswordHash, string newPasswordSalt)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "UPDATE [User] SET PasswordHash = @PasswordHash, PasswordSalt = @PasswordSalt WHERE ID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                    cmd.Parameters.AddWithValue("@PasswordSalt", newPasswordSalt);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddMovieToFavorites(int userId, int movieId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "INSERT INTO UserFavorite (UserID, MovieID) VALUES (@UserId, @MovieId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddMovieToWatchlist(int userId, int movieId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "INSERT INTO Watchlist (UserID, MovieID) VALUES (@UserId, @MovieId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoveMovieFromFavorites(int userId, int movieId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM UserFavorite WHERE UserID = @UserId AND MovieID = @MovieId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoveMovieFromWatchlist(int userId, int movieId)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "DELETE FROM Watchlist WHERE UserID = @UserId AND MovieID = @MovieId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@MovieId", movieId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private List<MovieDTO> GetMoviesForUser(int userId, string tableName)
        {
            List<MovieDTO> movies = new List<MovieDTO>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = $"SELECT m.* FROM [Movie] m " +
                               $"JOIN [{tableName}] um ON m.ID = um.MovieID " +
                               $"WHERE um.UserID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MovieDTO movie = new MovieDTO(
                                id: (int)reader["ID"],
                                title: reader["Title"] as string,
                                releaseDate: (DateTime)reader["ReleaseDate"],
                                description: reader["Description"] as string,
                                posterImageURL: reader["PosterImageURL"] as string,
                                trailerURL: reader["TrailerURL"] as string,
                                runtimeMinutes: (int)reader["RuntimeMinutes"],
                                averageRating: reader["AverageRating"] as decimal?,
                                genres: GetMovieGenres((int)reader["ID"]),
                                  directors: GetMovieDirectors((int)reader["ID"]),
                        actors: GetMovieActors((int)reader["ID"])
                            );
                            movies.Add(movie);
                        }
                    }
                }
            }
            return movies;
        }

        private List<string> GetMovieGenres(int movieId)
        {
            List<string> genres = new List<string>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = "SELECT g.Name FROM MovieGenre mg " +
                               "JOIN Genre g ON mg.GenreID = g.ID " +
                               "WHERE mg.MovieID = @MovieID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genres.Add(reader["Name"] as string);
                        }
                    }
                }
            }
            return genres;
        }
        private List<string> GetMovieDirectors(int movieId)
        {
            List<string> directors = new List<string>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = @"SELECT d.Name FROM MovieDirector md
                         JOIN Director d ON md.DirectorID = d.ID
                         WHERE md.MovieID = @MovieID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            directors.Add(reader["Name"] as string);
                        }
                    }
                }
            }
            return directors;
        }

        private List<string> GetMovieActors(int movieId)
        {
            List<string> actors = new List<string>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                string query = @"SELECT a.Name FROM MovieActor ma
                         JOIN Actor a ON ma.ActorID = a.ID
                         WHERE ma.MovieID = @MovieID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MovieID", movieId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actors.Add(reader["Name"] as string);
                        }
                    }
                }
            }
            return actors;
        }
    }
}
