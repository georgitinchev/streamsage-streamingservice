namespace DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureURL { get; set; }
        public UserSettingsDTO? Settings { get; set; }
        public List<MovieDTO>? FavoriteMovies { get; set; }
        public List<MovieDTO>? WatchList { get; set; }
        public List<int>? RecentlyWatchedMovieIds { get; set; }

        // main constructor
        public UserDTO(int id, string username, string email, string passwordHash, string passwordSalt, string firstName, string lastName, string profilePictureURL, UserSettingsDTO settings, List<MovieDTO> favoriteMovies, List<MovieDTO> watchList, List<int>? recentlyWatchedMovieIds)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePictureURL;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
            RecentlyWatchedMovieIds = recentlyWatchedMovieIds;
        }

        // No watchlist or favorite movies constructor
        public UserDTO(int id, string username, string email, string passwordHash, string passwordSalt, string firstName, string lastName, UserSettingsDTO settings)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            FirstName = firstName;
            LastName = lastName;
            Settings = settings;
        }
        // No password constructor
        public UserDTO(int id, string username, string email, string firstName, string lastName, UserSettingsDTO settings)
        {
            Id = id;
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Settings = settings;
        }
        // constructor with just first 3 elements
        public UserDTO(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
        }
    }
}
