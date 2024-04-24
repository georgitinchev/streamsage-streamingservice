using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicClassLibrary;
using LogicClassLibrary.Entities;

namespace DesktopApp
{
    public class DesktopController : UserInterface
    {
        private User? loggedInUser;
        private string? searchCriteria;
        private BackendService? backendService;

        public DesktopController()
        {
            backendService = new BackendService();
        }
        public void displayHomePage()
        {
        }
        public List<Movie> displayMoviePage()
        {
            if (backendService != null)
            {
                return backendService.GetAllMovies();
            }
            return new List<Movie>();
        }
        public bool loginUser(string username, string password)
        {
           return backendService.userManager.AuthenticateUser(username, password);
        }
        public void registerUser(string username, string email, string password, string firstName, string lastName, string settings)
        {
            backendService?.userManager.RegisterUser(username, email, password, firstName, lastName, settings);
        }

        public void logoutUser()
        {

        }
    }
}

// 1. Method to Login User
// 2. Method to Logout User
// 3. Method to Display Home Page
// 4. Method to Display Each Separate Page
// 5. Method to Display Movie Page