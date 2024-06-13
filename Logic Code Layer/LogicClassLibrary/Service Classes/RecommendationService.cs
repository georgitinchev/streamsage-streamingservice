using DTOs;
using LogicClassLibrary.Algorithmic;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;
using System;
using System.Collections.Generic;

namespace LogicClassLibrary.Service_Classes
{
    // Recommendation service class that takes the manager interface and the two recommendation classes
    public class RecommendationService : IRecommendationService
    {
        private IRecommendationManager recommendationManager;
        private BehaviorBasedRecommendation behaviorBasedRecommendation;
        private ContentBasedRecommendation contentBasedRecommendation;

        public RecommendationService(IRecommendationManager recommendationManager, ContentBasedRecommendation contentBasedRecommendation, BehaviorBasedRecommendation behaviorBasedRecommendation)
        {
            this.recommendationManager = recommendationManager;
            this.contentBasedRecommendation = contentBasedRecommendation;
            this.behaviorBasedRecommendation = behaviorBasedRecommendation;
        }

        // Method that recommends movies to a user based on recommendation type and number of recommendations
        public List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations, RecommendationType type)
        {
            switch (type)
            {
                case RecommendationType.BehaviorBased:
                    recommendationManager.SetStrategy(behaviorBasedRecommendation);
                    break;
                case RecommendationType.ContentBased:
                    recommendationManager.SetStrategy(contentBasedRecommendation);
                    break;
                default:
                    throw new ArgumentException("Invalid recommendation type.");
            }
            return recommendationManager.RecommendMoviesForUser(username, numRecommendations);
        }
    }
}
