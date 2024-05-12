using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{

    public interface UserInterfaceWeb
    {
        public void displayHomePage();
        public List<Movie> displayMoviePage();
        public bool loginUser(string username, string password);
        public void logoutUser();
        public void registerUser(string username, string password, string email, string firstName, string lastName);
        public bool UpdateUserProfile(string username, string email, string password, string firstName, string lastName, string profilePic, string settings);
        public List<Movie> SearchMovies(string criteria);
    }
}
