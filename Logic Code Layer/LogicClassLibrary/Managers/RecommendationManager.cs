using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Managers
{
    internal class RecommendationManager
    {
        private List<Movie> userPreferences;
        private List<Movie> movieCatalog;

        public void updateUserPreferences(List<Movie> newPreferences)
        {
            userPreferences = newPreferences;
        }

        public List<Movie> getRecommendedMovies(int userId, int numRecommendations)
        {
            return new List<Movie>();
        }

        public List<Movie> generateCollaborativeFilteringRecommendations(int userId, int numRecommendations)
        {
            return new List<Movie>();
        }

        public List<Movie> generateContentBasedRecommendations(int userId, int numRecommendations)
        {
            return new List<Movie>();
        }
    }
}
