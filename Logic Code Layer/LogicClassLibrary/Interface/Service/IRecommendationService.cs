using DTOs;
using LogicClassLibrary.Managers;

namespace LogicClassLibrary.Interface.Service
{
    public interface IRecommendationService
    {
        List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations, RecommendationType type);
    }
}
