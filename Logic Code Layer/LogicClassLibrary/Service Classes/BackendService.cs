using DataAccessLibrary;
using DataAccessLibrary.DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;
using System.Data;

namespace LogicClassLibrary
{
    public class BackendService
    {
        private UserManager userManager;
        private MovieManager movieManager;
        private ReviewManager reviewManager;
        private InterpretationManager interpretationManager;
        public RecommendationManager recommendationManager { get; private set; }
        private UserDAL userDAL;
        private MovieDAL movieDAL;
        private ReviewDAL reviewDAL;
        private InterpretationDAL interpretationDAL;
        public BackendService()
        {
            movieDAL = new MovieDAL();
            userDAL = new UserDAL();
            reviewDAL = new ReviewDAL();
            interpretationDAL = new InterpretationDAL();
            movieManager = new MovieManager(movieDAL);
            userManager = new UserManager(userDAL, movieManager);
            reviewManager = new ReviewManager(reviewDAL);
            interpretationManager = new InterpretationManager(interpretationDAL);
            recommendationManager = new RecommendationManager(movieDAL, userDAL);
        }

        public List<string> GetAllGenres()
        {
            return movieManager.GetAllGenres();
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
            return userManager?.ReadUser(id);
        }

        public User GetUser(string username)
        {
            return userManager?.ReadUser(username);
        }

        public List<Movie> SearchMovies(string criteria)
        {
            return movieManager.SearchMovies(criteria);
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
            return userManager.AuthenticateUser(username, password);
        }

        public void RegisterUser(string username, string email, string password, string firstName, string lastName, string profilePicture, string settings)
        {
            userManager.RegisterUser(username, email, password, firstName, lastName, profilePicture, settings);
        }

        public List<Movie> GetAllMovies()
        {
            return movieManager.movies;
        }

        public List<User> GetAllUsers()
        {
            return userManager.users;
        }

        public RecommendationManager RecommendationManager
        {
            get { return recommendationManager; }
        }
        public List<Movie> GetFeaturedMovies()
        {
            return GetAllMovies().Take(5).ToList();
        }

        public List<Movie> GetRandomMovies()
        {
            var allMovies = GetAllMovies();
            return allMovies.OrderBy(x => Guid.NewGuid()).Take(5).ToList();
        }
    }
}
