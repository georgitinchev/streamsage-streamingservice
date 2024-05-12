using DesktopApp;
using DTOs;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;

namespace StreamSageWAD
{
    public class WebController : UserInterfaceWeb
    {
        public User? loggedInUser { get; private set; } = null;
        private string? searchCriteria; // placeholder for search functionality
        public BackendService backendService;
        public WebController(User? _loggedInUser)
        {
            loggedInUser = _loggedInUser;
            searchCriteria = "";
            backendService = new BackendService();
        }

        public WebController()
        {
            searchCriteria = "";
            backendService = new BackendService();
        }
        public void displayHomePage()
        {
            // implement
        }

        public List<Movie> SearchMovies(string criteria)
        {
            searchCriteria = criteria;
            return backendService.SearchMovies(criteria);
        }
        public bool UpdateUserProfile(string username, string email, string password, string firstName, string lastName, string profilePic, string setings)
        {
            // implement
            return false;
        }

        public List<Movie> displayMoviePage()
        {
            return backendService.GetAllMovies();
        }

        public bool loginUser(string username, string password)
        {
            bool isAuthenticated = backendService.AuthenticateUser(username, password);
            if (isAuthenticated)
            {
                loggedInUser = backendService.GetUser(username);
            }
            return isAuthenticated;
        }
        public void registerUser(string username, string password, string email, string firstName, string lastName)
        {
            backendService.RegisterUser(username, email, password, firstName, lastName, "", "");
            loggedInUser = backendService.GetUser(username);
        }
        public void logoutUser()
        {
            loggedInUser = null; // clear the logged-in user
        }
    }
}
