using DTOs;

namespace LogicClassLibrary.Interface.Algorhitmic
{
    public interface IRecommendationStrategy
    {
        List<MovieDTO> RecommendMoviesBasedOnUserBehavior(string username, List<MovieDTO> allMovies);
        List<MovieDTO> RecommendMoviesBasedOnContent(string username, List<MovieDTO> allMovies, int numRecommendations = 5);
    }
}
