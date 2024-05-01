using LogicClassLibrary.Entities;
using DataAccessLibrary;
using System.Data;
using LogicClassLibrary.Managers;
using DataAccessLibrary.DataAccessLibrary;
using DTOs;

namespace LogicClassLibrary
{
    public class BackendService
    {
        private UserManager userManager;
        private MovieManager movieManager;
        private ReviewManager reviewManager;
        private InterpretationManager interpretationManager;
        private RecommendationManager recommendationManager;
        private UserDAL userDAL;
        private MovieDAL movieDAL;
        private ReviewDAL reviewDAL;
        private InterpretationDAL interpretationDAL;
        public BackendService()
        {
            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id=dbi524441_streamsage;Password=e9999619;TrustServerCertificate=true";
            movieDAL = new MovieDAL(connectionString);
            userDAL = new UserDAL(connectionString);
            reviewDAL = new ReviewDAL(connectionString);
            interpretationDAL = new InterpretationDAL(connectionString);
            movieManager = new MovieManager(movieDAL);
            userManager = new UserManager(userDAL, movieManager);
            reviewManager = new ReviewManager(reviewDAL);
            interpretationManager = new InterpretationManager(interpretationDAL);
            recommendationManager = new RecommendationManager();
        }

        public Movie GetMovie(int id)
        {
            return movieManager.ReadMovie(id);
        }

        public void AddMovie(MovieDTO movie)
        {
            movieManager.CreateMovie(movie);
		}

        public void UpdateMovie(MovieDTO movieDto)
        {
            movieManager.UpdateMovie(movieDto);
        }

        public void DeleteMovie(int id)
        {
			movieManager.DeleteMovie(id);
        }

        public User GetUser(int id)
        {
            return userManager.ReadUser(id);
        }

        public void DeleteUser(int id)
        {
            userManager.DeleteUser(id);
        }

        public void UpdateUser(UserDTO userDto)
        {
            userManager.UpdateUser(userDto);
        }

        public void ChangePassword(string username, string newPassword)
        {
            userManager.ChangePassword(username, newPassword);
        }
        public bool AuthenticateUser(string username, string password)
        {
            return userManager.AuthenticateUser(username,password);
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName, string profilePicture ,string settings)
        {
            userManager.RegisterUser(username, email, password, firstName, lastName,profilePicture, settings);
        }
		
        public List<Movie> GetAllMovies()
        {
            return movieManager.movies;
		}

        public List<User> GetAllUsers()
        {
            return userManager.users;
        }
    }
}
