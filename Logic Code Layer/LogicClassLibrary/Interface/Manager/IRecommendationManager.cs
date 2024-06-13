using DTOs;
using LogicClassLibrary.Interface.Algorhitmic;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IRecommendationManager
    {
        List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations);
        void SetStrategy(IRecommendationStrategy strategy);
    }
}
