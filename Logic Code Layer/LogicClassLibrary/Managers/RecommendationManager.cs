using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class RecommendationManager : IRecommendationManager
    {
        private IRecommendationStrategy recommendationStrategy;
        private IUserManager userManager;
        private IMovieManager movieManager;
        public RecommendationManager(IRecommendationStrategy recommendationStrategy, IUserManager userManager, IMovieManager movieManager)
        {
            this.recommendationStrategy = recommendationStrategy;
            this.userManager = userManager;
            this.movieManager = movieManager;
        }
        public List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations, RecommendationType type)
        {
            List<Movie> allMovies = movieManager.GetAllMovies();
            List<MovieDTO> allMovieDTOs = allMovies.Select(movie => movieManager.TransformEntityToDTO(movie)).ToList();
            return recommendationStrategy.RecommendMovies(username, allMovieDTOs, numRecommendations);
        }

        public void SetRecommendationStrategy(IRecommendationStrategy strategy)
        {
            this.recommendationStrategy = strategy;
        }

        public enum RecommendationType
        {
            BehaviorBased,
            ContentBased
        }
    }
}
