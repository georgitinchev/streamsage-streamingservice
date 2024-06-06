namespace DTOs
{
    public class UserDTO
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string? Email { get; private set; }
        public string? PasswordHash { get; private set; }
        public string? PasswordSalt { get; private set; }
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? ProfilePictureURL { get; private set; }
        public string? Settings { get; private set; }
        public List<MovieDTO>? FavoriteMovies { get; private set; }
        public List<MovieDTO>? WatchList { get; private set; }

        // main constructor
        public UserDTO(int id, string username, string email, string passwordHash, string passwordSalt, string firstName, string lastName, string profilePictureURL, string settings, List<MovieDTO> favoriteMovies, List<MovieDTO> watchList)
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
        }

        // No watchlist or favorite movies constructor
        public UserDTO(int id, string username, string email, string passwordHash, string passwordSalt, string firstName, string lastName, string settings)
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
        public UserDTO(int id, string username, string email, string firstName, string lastName, string settings)
        {
            Id = id;
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Settings = settings;
        }
        // pwd hash + salt setter
        public void SetPasswordHashAndSalt(string passwordHash, string passwordSalt)
        {
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }
    }
}
