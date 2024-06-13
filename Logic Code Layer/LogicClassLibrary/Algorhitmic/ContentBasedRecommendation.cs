using DTOs;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Manager;
using System.Collections.Generic;
using System.Linq;

namespace LogicClassLibrary.Algorithmic
{
    // Content-based algorithm: Recommends movies based on commonality in genres, directors and actors of movies with user's favorite movies
    public class ContentBasedRecommendation : IRecommendationStrategy
    {
        private IUserManager userManager;
        private IMovieManager movieManager;

        public ContentBasedRecommendation(IUserManager userManager, IMovieManager movieManager)
        {
            this.userManager = userManager;
            this.movieManager = movieManager;
        }

        public List<MovieDTO> RecommendMovies(string username, List<MovieDTO> allMovies, int numRecommendations)
        {
            // Get the user's favorite movies
            var user = userManager.Read(username);
            var favoriteMovies = user.FavoriteMovies;

            // For each movie in allMovies, calculate a similarity score with the user's favorite movies
            // The similarity score is based on how many genres, directors, and actors the movies have in common
            var similarityScores = allMovies.ToDictionary(
                m => m,
                m => favoriteMovies.Sum(f => f.Genres.Intersect(m.Genres).Count() + f.Directors.Intersect(m.Directors).Count() + f.Actors.Intersect(m.Actors).Count())
            );

            // Select the movies with the highest similarity scores
            var recommendedMovies = similarityScores.OrderByDescending(kv => kv.Value)
                                                    .Select(kv => kv.Key)
                                                    .Take(numRecommendations)
                                                    .ToList();

            // Return the recommendations with added randomness
            return recommendedMovies.OrderBy(m => Guid.NewGuid()).Take(numRecommendations).ToList();
        }
    }
}
