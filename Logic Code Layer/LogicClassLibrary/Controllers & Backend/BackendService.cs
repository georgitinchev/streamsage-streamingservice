using LogicClassLibrary.Entities;
using DataAccessLibrary;
using System.Data;
using LogicClassLibrary.Managers;
using DataAccessLibrary.DataAccessLibrary;

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
            userManager = new UserManager();
            movieManager = new MovieManager();
            reviewManager = new ReviewManager();
            interpretationManager = new InterpretationManager();
            recommendationManager = new RecommendationManager();
            movieDAL = new MovieDAL(connectionString);
            userDAL = new UserDAL(connectionString);
            reviewDAL = new ReviewDAL(connectionString);
            interpretationDAL = new InterpretationDAL(connectionString);
        }
    }
}
