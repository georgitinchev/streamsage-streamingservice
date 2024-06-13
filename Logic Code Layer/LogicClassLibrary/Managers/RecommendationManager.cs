using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Manager;
using System;
using System.Collections.Generic;

namespace LogicClassLibrary.Managers
{
    public class RecommendationManager : IRecommendationManager
    {
        private IRecommendationStrategy recommendationStrategy;
        private IUserManager userManager;
        private IMovieManager movieManager;
        private RandomPageSelector randomPageSelector;

        public RecommendationManager(IUserManager userManager, IMovieManager movieManager, RandomPageSelector randomPageSelector)
        {
            this.userManager = userManager;
            this.movieManager = movieManager;
            this.randomPageSelector = randomPageSelector;
        }

        public void SetStrategy(IRecommendationStrategy strategy)
        {
            try
            {
                recommendationStrategy = strategy;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to set recommendation strategy.", ex);
            }
        }

        public List<MovieDTO> RecommendMoviesForUser(string username, int numRecommendations)
        {
            try
            {
                if (recommendationStrategy == null)
                {
                    throw new InvalidOperationException("Recommendation strategy has not been set.");
                }

                int pageSize = 20; // Determine page size
                List<MovieDTO> allMovieDTOs = randomPageSelector.SelectRandomPage(pageSize);

                // Apply the strategy to recommend movies
                return recommendationStrategy.RecommendMovies(username, allMovieDTOs, numRecommendations);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to recommend movies for user.", ex);
            }
        }
    }
}
