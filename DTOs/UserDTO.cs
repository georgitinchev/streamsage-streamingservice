using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Settings { get; set; }
        public List<MovieDTO>? FavoriteMovies { get; set; }
        public List<MovieDTO>? WatchList { get; set; }

        public UserDTO(int id, string username, string email, string passwordHash, string firstName, string lastName, string settings, List<MovieDTO> favoriteMovies, List<MovieDTO> watchList)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
        }
    }
}
