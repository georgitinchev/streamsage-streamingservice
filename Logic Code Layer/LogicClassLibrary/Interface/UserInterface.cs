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
        public void displayMoviePage();
        public void loginUser(string username, string password);
        public void logoutUser();
    }
}
