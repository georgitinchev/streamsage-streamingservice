using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public UserDTO(int id, string username, string email, string passwordHash, string passwordSalt, string firstName, string lastName, string profilePicture, string settings, List<MovieDTO> favoriteMovies, List<MovieDTO> watchList)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
        }

        public UserDTO(int id, string username, string? email, string firstName, string lastName, string profilePicture, string settings)
        {
            Id = id;
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            ProfilePictureURL = profilePicture;
            Settings = settings;
        }
    }
}
