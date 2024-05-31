using DTOs;
using LogicClassLibrary.Managers;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IRecommendationManager
    {
        Task<List<MovieDTO>> RecommendMoviesForUser(string username, int numRecommendations, RecommendationManager.RecommendationType type);
    }
}
