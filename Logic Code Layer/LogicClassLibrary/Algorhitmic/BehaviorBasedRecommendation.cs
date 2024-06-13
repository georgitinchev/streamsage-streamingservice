using DTOs;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Manager;
using System.Collections.Generic;
using System.Linq;

namespace LogicClassLibrary.Algorithmic
{
    // Behavior-based algorithm: Recommends movies based on the favorite movies and watchlist of users with similar tastes
    public class BehaviorBasedRecommendation : IRecommendationStrategy
    {
        private IUserManager userManager;

        public BehaviorBasedRecommendation(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies, int numRecommendations)
        {
            // Get the user's favorite movies and watchlist
            var user = userManager.Read(username);
            var favoriteMovies = user.FavoriteMovies ?? new List<MovieDTO>();
            var watchlist = user.WatchList ?? new List<MovieDTO>();

            // Find other users who have similar favorites and watchlist
            var similarUsers = userManager.GetAllUsers()
                                          .Where(u => (u.FavoriteMovies ?? new List<MovieDTO>()).Intersect(favoriteMovies).Any()
                                                   || (u.WatchList ?? new List<MovieDTO>()).Intersect(watchlist).Any())
                                          .ToList();

            // Find the most popular movies among these users
            var popularMovies = similarUsers.SelectMany(u => (u.FavoriteMovies ?? new List<MovieDTO>()).Concat(u.WatchList ?? new List<MovieDTO>()))
                                            .GroupBy(m => m)
                                            .OrderByDescending(g => g.Count())
                                            .Select(g => g.Key)
                                            .ToList();

            // If there are not enough popular movies, add top-rated or trending movies
            if (popularMovies.Count < numRecommendations)
            {
                var topRatedMovies = allMovies.OrderByDescending(m => m.AverageRating).Take(numRecommendations - popularMovies.Count);
                popularMovies.AddRange(topRatedMovies);
            }

            // Select the top numRecommendations from these movies
            var recommendedMovies = popularMovies.Take(numRecommendations).ToList();

            // Return the recommendations with added randomness
            return recommendedMovies.OrderBy(m => Guid.NewGuid()).Take(numRecommendations).ToList();
        }
    }
}
