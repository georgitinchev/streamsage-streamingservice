using DTOs;
using LogicClassLibrary.Interface.Algorhitmic;

namespace LogicClassLibrary.Algorithmic
{
    public class BehaviorBasedRecommendation : IRecommendationStrategy
    {
        public List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies, int numRecommendations)
        {
            // Get the user's favorite movies and watchlist
            // Find the most common genres in these lists
            // Select movies from allMovies that belong to these genres
            // Return the selected movies
            throw new NotImplementedException();
        }
    }
}
