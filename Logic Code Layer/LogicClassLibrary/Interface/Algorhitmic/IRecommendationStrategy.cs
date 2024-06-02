using DTOs;

namespace LogicClassLibrary.Interface.Algorhitmic
{
    public interface IRecommendationStrategy
    {
        List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies, int numRecommendations);
    }
}
