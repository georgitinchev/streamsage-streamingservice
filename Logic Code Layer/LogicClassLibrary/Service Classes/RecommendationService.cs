using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Service_Classes
{
    public class RecommendationService : IRecommendationService
    {
        private IRecommendationManager recommendationManager;

        public RecommendationService(IRecommendationManager recommendationManager)
        {
            this.recommendationManager = recommendationManager;
        }

        public List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations, RecommendationManager.RecommendationType type)
        {
            return recommendationManager.RecommendMoviesForUser(username, numRecommendations, type);
        }
    }
}
