using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Settings { get; set; }

        public List<Movie>? FavoriteMovies { get; set; }
        public List<Movie>? WatchList { get; set; }

        public User(int id, string username, string passwordHash, string email, string? firstName, string? lastName, string? settings, List<Movie> favoriteMovies, List<Movie> watchList)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Settings = settings;
            FavoriteMovies = favoriteMovies;
            WatchList = watchList;
        }
    }
}
