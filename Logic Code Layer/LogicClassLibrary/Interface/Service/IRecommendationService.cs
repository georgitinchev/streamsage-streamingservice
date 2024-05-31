using DTOs;
using LogicClassLibrary.Managers;

namespace LogicClassLibrary.Interface.Service
{
    public interface IRecommendationService
    {
        Task<List<MovieDTO>> RecommendMoviesForUser(string username, int numRecommendations, RecommendationManager.RecommendationType type);
    }
}
