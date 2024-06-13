using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Helpers;

namespace LogicClassLibrary.Entities
{
    public class User : Entity
    {
        private readonly IPasswordHelper _passwordHelper;
        public override int Id { get; protected set; }
        public string Username { get; private set; }
        private string PasswordHash;
        private string PasswordSalt;
        public string? Email { get; private set; }
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public byte[]? ProfilePictureURL { get; private set; }
        public UserSettings? Settings { get; private set; }
        public List<Movie>? FavoriteMovies { get; private set; }
        public List<Movie>? WatchList { get; private set; }
        public List<int>? RecentlyWatchedMovieIds { get; private set; }

        // constructor with pwd helper interface
        public User(int id, string username, string password, string? email, string? firstName, string? lastName, byte[]? profilePicture, UserSettings? settings, List<Movie> favoriteMovies, List<Movie> watchList, List<int>? recentlyWatchedMovieIds, IPasswordHelper passwordHelper)
        {
            _passwordHelper = passwordHelper;
            Id = id;
            Username = username;
            SetPassword(password);
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
            RecentlyWatchedMovieIds = recentlyWatchedMovieIds;
        }

        // constructor without pwd helper interface
        public User(int id, string username, string passwordHash, string passwordSalt, string? email, string? firstName, string? lastName, byte[]? profilePicture, UserSettings? settings, List<Movie> favoriteMovies, List<Movie> watchList, List<int>? recentlyWatchedMovieIds)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
            RecentlyWatchedMovieIds = recentlyWatchedMovieIds;
        }


        public void Update(string username, string? email, string? firstName, string? lastName, byte[]? profilePicture, UserSettings? settings, List<Movie> favoriteMovies, List<Movie> watchList, List<int>? recentlyWatched)
        {
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
            RecentlyWatchedMovieIds = recentlyWatched;
        }

        public void Update(string username, string? email, string? firstName, string? lastName, byte[] profilePicture, UserSettings? settings)
        {
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
        }

        public void SetPassword(string password)
        {
            PasswordSalt = _passwordHelper.GenerateSalt();
            PasswordHash = _passwordHelper.HashPassword(password, PasswordSalt);
        }
        public void UpdateId(int id)
        {
            Id = id;
        }

        public void UpdateProfilePicture(byte[] profilePicture)
        {
            ProfilePictureURL = profilePicture;
        }

        public bool VerifyPassword(string password)
        {
            return PasswordHash == _passwordHelper.HashPassword(password, PasswordSalt);
        }

        public void SetPasswordHashAndSalt(string passwordHash, string passwordSalt)
        {
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        public string GetPasswordHash()
        {
            return PasswordHash;
        }

        public string GetPasswordSalt()
        {
            return PasswordSalt;
        }
    }
}
