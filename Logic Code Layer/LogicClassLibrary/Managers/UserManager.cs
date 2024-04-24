using DataAccessLibrary.DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
    public class UserManager : GeneralManager
    {
        private List<User>? users;
        private UserDAL? userDAL;
        private MovieManager movieManager;

        public UserManager(UserDAL userDAL, MovieManager movieManager)
        {
            users = new List<User>();
            this.userDAL = userDAL;
            this.movieManager = movieManager;
            GetAllUsers();
        }
        public override Entity? TransformDTOtoEntity(object dto)
        {
            if (dto is UserDTO userDTO)
            {
                if (userDTO.Username == null || userDTO.PasswordHash == null || userDTO.Email == null)
                {
                    throw new ArgumentException("Username, PasswordHash, and Email cannot be null.");
                }
                List<Movie> favoriteMovies = TransformDTOsToMovies(userDTO.FavoriteMovies);
                List<Movie> watchList = TransformDTOsToMovies(userDTO.WatchList);
                User user = new User(userDTO.Id, userDTO.Username, userDTO.PasswordHash, userDTO.Email, userDTO.FirstName, userDTO.LastName, userDTO.Settings, favoriteMovies, watchList);
                return user;
            }
            return null;
        }

        public List<Movie> TransformDTOsToMovies(List<MovieDTO> movieDTOs)
        {
            List<Movie> movies = new List<Movie>();
            foreach (var movieDTO in movieDTOs)
            {
                Movie movie = movieManager.TransformDTOtoEntity(movieDTO) as Movie;
                if (movie != null)
                {
                    movies.Add(movie);
                }
            }
            return movies;
        }

        private void GetAllUsers()
        {
            try
            {
                var userDTOs = userDAL.ReadAllUsers();
                users = userDTOs.Select(dto => TransformDTOtoEntity(dto) as User).Where(user => user != null).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private User? GetUserByName(string username)
        {
            return users?.FirstOrDefault(user => user.Username == username);
        }
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                UserDTO userDTO = userDAL?.GetUserByUsername(username);
                if (userDTO != null)
                {
                    string hashedPassword = PasswordHelper.HashPassword(password);
                    return hashedPassword == userDTO.PasswordHash;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName, string settings)
        {
            try
            {
                string passwordHash = PasswordHelper.HashPassword(password);
                UserDTO userDTO = new UserDTO(0, username, email, passwordHash, firstName, lastName, settings, new List<MovieDTO>(), new List<MovieDTO>());
                userDAL?.CreateUser(userDTO);
                User user = TransformDTOtoEntity(userDTO) as User;
                if (user != null)
                {
                    users?.Add(user);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void changePassword(string newPassword)
        {
        }

        private void updateEmail(string newEmail)
        {
        }

        private void addToFavorites(int movieId)
        {

        }

        private void removeFromFavorites(int movieId)
        {

        }

        private void addToWatchlist(int movieId)
        {

        }

        private void removefromWatchlist(int movieId)
        {

        }

        private void updateUserRole(int userId, string newRole)
        {

        }
    }
}
