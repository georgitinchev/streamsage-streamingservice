using DataAccessLibrary.Exception;
using DTOs;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
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
            try
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
                                    profilePictureURL: reader["ProfilePictureURL"] as byte[],
                                    settings: reader["Settings"] == DBNull.Value ? null : JsonConvert.DeserializeObject<UserSettingsDTO>(reader["Settings"] as string),
                                    favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                    watchList: GetMoviesForUser((int)reader["ID"], "Watchlist"),
                                    recentlyWatchedMovieIds: GetRecentlyWatchedMoviesForUser((int)reader["ID"])
                                );
                                users.Add(user);
                            }
                        }
                    }
                }
                return users;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading all users"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading all users"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading all users"), ex);
            }
        }

        public int CreateUser(UserDTO user)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO [User] (Username, Email, PasswordHash, FirstName, LastName, ProfilePictureURL, Settings, PasswordSalt) " +
                                   "OUTPUT INSERTED.ID " +
                                   "VALUES (@Username, @Email, @PasswordHash, @FirstName, @LastName, @ProfilePictureURL, @Settings, @PasswordSalt)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@LastName", user.LastName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Settings", user.Settings == null ? (object)DBNull.Value : JsonConvert.SerializeObject(user.Settings));
                        cmd.Parameters.AddWithValue("@PasswordSalt", user.PasswordSalt);
                        user.Id = (int)cmd.ExecuteScalar();
                    }
                }
                return user.Id;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("creating a user"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("creating a user"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("creating a user"), ex);
            }
        }


        public UserDTO? GetUserByUsername(string username)
        {
            try
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
                                    profilePictureURL: reader["ProfilePictureURL"] as byte[],
                                    settings: reader["Settings"] == DBNull.Value ? null : JsonConvert.DeserializeObject<UserSettingsDTO>(reader["Settings"] as string),
                                    favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                    watchList: GetMoviesForUser((int)reader["ID"], "Watchlist"),
                                    recentlyWatchedMovieIds: GetRecentlyWatchedMoviesForUser((int)reader["ID"])
                                );
                            }
                        }
                    }
                }
                return user;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading a user by username"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading a user by username"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading a user by username"), ex);
            }
        }

        public UserDTO? GetUserById(int userId)
        {
            try
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
                                    profilePictureURL: reader["ProfilePictureURL"] as byte[],
                                    settings: reader["Settings"] == DBNull.Value ? null : JsonConvert.DeserializeObject<UserSettingsDTO>(reader["Settings"] as string),
                                    favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                    watchList: GetMoviesForUser((int)reader["ID"], "Watchlist"),
                                    recentlyWatchedMovieIds: GetRecentlyWatchedMoviesForUser((int)reader["ID"])
                                );
                            }
                        }
                    }
                }
                return user;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading a user by ID"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading a user by ID"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading a user by ID"), ex);
            }
        }

        public void UpdateUser(UserDTO user)
        {
            try
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
                        cmd.Parameters.AddWithValue("@Settings", user.Settings == null ? (object)DBNull.Value : JsonConvert.SerializeObject(user.Settings));
                        cmd.Parameters.AddWithValue("@PasswordSalt", user.PasswordSalt);
                        cmd.Parameters.AddWithValue("@Id", user.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("updating a user"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("updating a user"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("updating a user"), ex);
            }
        }

        // Update user without password method
        public void UpdateUserWithoutPassword(UserDTO user)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();

                    List<string> updateClauses = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrEmpty(user.Username))
                    {
                        updateClauses.Add("Username = @Username");
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                    }

                    if (!string.IsNullOrEmpty(user.Email))
                    {
                        updateClauses.Add("Email = @Email");
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                    }

                    if (!string.IsNullOrEmpty(user.FirstName))
                    {
                        updateClauses.Add("FirstName = @FirstName");
                        cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    }

                    if (!string.IsNullOrEmpty(user.LastName))
                    {
                        updateClauses.Add("LastName = @LastName");
                        cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    }

                    if (user.ProfilePictureURL != null)
                    {
                        updateClauses.Add("ProfilePictureURL = @ProfilePictureURL");
                        cmd.Parameters.AddWithValue("@ProfilePictureURL", user.ProfilePictureURL);
                    }

                    if (updateClauses.Count > 0)
                    {
                        string query = "UPDATE [User] SET " + string.Join(", ", updateClauses) + " WHERE ID = @Id";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Id", user.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("updating a user without password"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("updating a user without password"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("updating a user without password"), ex);
            }
        }

        public void DeleteUser(int userId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("deleting a user"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("deleting a user"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("deleting a user"), ex);
            }
        }

        public void ChangePassword(int userId, string newPasswordHash, string newPasswordSalt)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("changing a user's password"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("changing a user's password"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("changing a user's password"), ex);
            }
        }

        public void AddMovieToFavorites(int userId, int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("adding a movie to favorites"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("adding a movie to favorites"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("adding a movie to favorites"), ex);
            }
        }

        public void AddMovieToWatchlist(int userId, int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("adding a movie to watchlist"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("adding a movie to watchlist"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("adding a movie to watchlist"), ex);
            }
        }

        public void RemoveMovieFromFavorites(int userId, int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("removing a movie from favorites"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("removing a movie from favorites"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("removing a movie from favorites"), ex);
            }
        }

        public void RemoveMovieFromWatchlist(int userId, int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("removing a movie from watchlist"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("removing a movie from watchlist"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("removing a movie from watchlist"), ex);
            }
        }

        private List<MovieDTO> GetMoviesForUser(int userId, string tableName)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading movies for a user"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading movies for a user"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading movies for a user"), ex);
            }
        }

        private List<string> GetMovieGenres(int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading movie genres"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading movie genres"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading movie genres"), ex);
            }
        }
        private List<string> GetMovieDirectors(int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading movie directors"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading movie directors"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading movie directors"), ex);
            }
        }

        private List<string> GetMovieActors(int movieId)
        {
            try
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
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading movie actors"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading movie actors"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading movie actors"), ex);
            }
        }

        // get users page method

        public List<UserDTO> GetUsersPage(int pageNumber, int pageSize)
        {
            try
            {
                var users = new List<UserDTO>();
                var userQuery = @"
        WITH UserPage AS (
            SELECT 
                u.ID, u.Username, u.Email, u.FirstName, u.LastName, 
                u.ProfilePictureURL, u.Settings, u.PasswordHash, u.PasswordSalt,
                ROW_NUMBER() OVER (ORDER BY u.ID) AS RowNum
            FROM [User] u
        )
        SELECT 
            up.ID, up.Username, up.Email, up.FirstName, up.LastName, 
            up.ProfilePictureURL, up.Settings, up.PasswordHash, up.PasswordSalt
        FROM UserPage up
        WHERE up.RowNum BETWEEN @StartRow AND @EndRow
        ORDER BY up.ID";

                int startRow = (pageNumber - 1) * pageSize + 1;
                int endRow = pageNumber * pageSize;

                using (var connection = CreateConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(userQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StartRow", startRow);
                        command.Parameters.AddWithValue("@EndRow", endRow);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var userId = reader.GetInt32(0);
                                var user = new UserDTO(
                                id: (int)reader["ID"],
                                username: reader["Username"] as string,
                                email: reader["Email"] as string,
                                passwordHash: reader["PasswordHash"] as string,
                                passwordSalt: reader["PasswordSalt"] as string,
                                firstName: reader["FirstName"] as string,
                                lastName: reader["LastName"] as string,
                                profilePictureURL: reader["ProfilePictureURL"] as byte[],
                                settings: reader["Settings"] == DBNull.Value ? null : JsonConvert.DeserializeObject<UserSettingsDTO>(reader["Settings"] as string),
                                favoriteMovies: GetMoviesForUser((int)reader["ID"], "UserFavorite"),
                                watchList: GetMoviesForUser((int)reader["ID"], "Watchlist"),
                                recentlyWatchedMovieIds: GetRecentlyWatchedMoviesForUser((int)reader["ID"])
                                );
                                users.Add(user);
                            }
                        }
                    }
                }
                return users;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("getting users page"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("getting users page"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("getting users page"), ex);
            }
        }

        public void AddMovieToRecentlyWatched(int userId, int movieId)
        {
            try
            {
                var recentlyWatchedMovies = GetRecentlyWatchedMoviesForUser(userId);
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    if (recentlyWatchedMovies.Contains(movieId))
                    {
                        string updateQuery = "UPDATE RecentlyWatched SET WatchedDate = @WatchedDate WHERE UserID = @UserId AND MovieID = @MovieId";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.Parameters.AddWithValue("@MovieId", movieId);
                            cmd.Parameters.AddWithValue("@WatchedDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO RecentlyWatched (UserID, MovieID, WatchedDate) VALUES (@UserId, @MovieId, @WatchedDate)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.Parameters.AddWithValue("@MovieId", movieId);
                            cmd.Parameters.AddWithValue("@WatchedDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("adding a movie to recently watched"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("adding a movie to recently watched"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("adding a movie to recently watched"), ex);
            }
        }


        public void RemoveMovieFromRecentlyWatched(int userId, int movieId)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM RecentlyWatched WHERE UserID = @UserId AND MovieID = @MovieId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("removing a movie from recently watched"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("removing a movie from recently watched"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("removing a movie from recently watched"), ex);
            }
        }
        public List<int> GetRecentlyWatchedMoviesForUser(int userId)
        {
            try
            {
                List<int> movieIds = new List<int>();

                using (SqlConnection conn = CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT MovieID FROM RecentlyWatched WHERE UserID = @UserId ORDER BY WatchedDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                movieIds.Add((int)reader["MovieID"]);
                            }
                        }
                    }
                }
                return movieIds;
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("reading recently watched movies for a user"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("reading recently watched movies for a user"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("reading recently watched movies for a user"), ex);
            }
        }

        public int GetTotalUsers()
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User]", connection))
                    {
                        return (int)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(DataAccessException.GetDatabaseErrorMessage("getting total users"), ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new DataAccessException(DataAccessException.GetInvalidOperationErrorMessage("getting total users"), ex);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException(DataAccessException.GetUnexpectedErrorMessage("getting total users"), ex);
            }
        }
    }
}
