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
        private MovieDAL movieDAL;
        public BackendService()
        {
            userManager = new UserManager();
            movieManager = new MovieManager();
            reviewManager = new ReviewManager();
            interpretationManager = new InterpretationManager();
            movieDAL = new MovieDAL();
        }
        public List<Movie> GetMovies()
        {
            var dataTable = movieDAL.GetMovies();
            var movies = new List<Movie>();
            foreach (DataRow row in dataTable.Rows)
            {
                var movie = new Movie
                {
                    Id = (int)row["MovieID"],
                    Title = row["Title"].ToString(),
                    Year = (DateTime)row["ReleaseDate"],
                    Description = row["Description"].ToString(),
                    PosterImageURL = row["PosterImageURL"].ToString(),
                    TrailerURL = row["TrailerURL"].ToString(),
                };
                movies.Add(movie);
            }
            return movies;
        }
    }
}
