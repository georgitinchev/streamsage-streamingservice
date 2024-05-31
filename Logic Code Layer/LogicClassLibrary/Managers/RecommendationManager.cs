using DataAccessLibrary.DataAccessLibrary;
using DTOs;

namespace LogicClassLibrary.Managers
{
    public class RecommendationManager
    {
        private MovieRecommender movieRecommender;
        private MovieDAL movieDAL;
        public RecommendationManager(MovieDAL movieDAL, UserDAL userDAL)
        {
            movieRecommender = new MovieRecommender(userDAL);
            this.movieDAL = movieDAL;
        }
        public async Task<List<MovieDTO>> RecommendMoviesForUser(string username, int numRecommendations, RecommendationType type)
        {
            List<MovieDTO> allMovies = await GetAllMovies();

            switch (type)
            {
                case RecommendationType.BehaviorBased:
                    return movieRecommender.RecommendMoviesBasedOnUserBehavior(username, allMovies).Take(numRecommendations).ToList();
                case RecommendationType.ContentBased:
                    return movieRecommender.RecommendMoviesBasedOnContent(username, allMovies).Take(numRecommendations).ToList();
                default:
                    return new List<MovieDTO>();
            }
        }

        private async Task<List<MovieDTO>> GetAllMovies()
        {
            return await Task.Run(() => movieDAL.ReadAllMovies());
        }

        public enum RecommendationType
        {
            BehaviorBased,
            ContentBased
        }
    }
}
