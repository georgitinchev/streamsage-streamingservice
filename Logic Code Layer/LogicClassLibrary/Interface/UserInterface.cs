using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{

    public interface UserInterface
    {
        public void displayHomePage();
        public List<Movie> displayMoviePage();
        public void loginUser(string username, string password);
        public void logoutUser();
    }
}
