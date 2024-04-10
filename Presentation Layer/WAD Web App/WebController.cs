using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;

namespace StreamSageWAD
{
    public class WebController
    {
        private MovieManager movieManager;
        private ReviewManager? reviewManager;
        public WebController()
        {
            movieManager = new MovieManager();
        }
        public List<Movie> BrowseMovies()
        {
            return movieManager.GetMovies();
        }
        public void viewMovieDetails(int movieId)
        {
            //return movieManager.Get(movieId);
        }
        public void viewReviews(int movieId)
        {
            //return reviewManager.getMovieReviews(movieId);
        }
        public void viewInterpretations(int movieId)
        {

        }
    }
}
