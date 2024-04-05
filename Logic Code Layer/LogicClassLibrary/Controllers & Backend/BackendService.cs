using LogicClassLibrary.Entities;
using DataAccessLibrary;
using System.Data;
using LogicClassLibrary.Managers;

namespace LogicClassLibrary
{
    public class BackendService
    {
        private UserManager userManager;
        private MovieManager movieManager;
        private ReviewManager reviewManager;
        private InterpretationManager interpretationManager;
        public BackendService()
        {
            userManager = new UserManager();
            movieManager = new MovieManager();
            reviewManager = new ReviewManager();
            interpretationManager = new InterpretationManager();
        }
    }
}
