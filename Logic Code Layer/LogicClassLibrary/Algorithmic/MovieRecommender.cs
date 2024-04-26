using LogicClassLibrary.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LogicClassLibrary.Managers
{
    public class MovieRecommender
    {
        public List<Movie> RecommendMoviesBasedOnUserBehavior(User user, List<User> allUsers, List<Movie> allMovies)
        {
            List<int> movieScores = new List<int>(new int[allMovies.Count]); 

            foreach (User otherUser in allUsers)
            {
                if (otherUser == user) continue;
                // Calculate similarity score based on the number of favorite movies in common
                int similarityScore = otherUser.FavoriteMovies.Intersect(user.FavoriteMovies).Count();

                foreach (Movie movie in otherUser.FavoriteMovies)
                {
                    if (!user.FavoriteMovies.Contains(movie))
                    {
                        // Add the similarity score to the corresponding movie's score
                        movieScores[allMovies.IndexOf(movie)] += similarityScore;
                    }
                }
            }

            // Recommend the movies with the highest scores
            List<Movie> recommendedMovies = new List<Movie>();
            for (int i = 0; i < 5 && i < movieScores.Count; i++)
            {
                int maxScoreIndex = movieScores.IndexOf(movieScores.Max());
                recommendedMovies.Add(allMovies[maxScoreIndex]);
                movieScores[maxScoreIndex] = int.MinValue;
            }
            return recommendedMovies;
        }

        public List<Movie> RecommendMoviesBasedOnContent(User user, List<Movie> allMovies)
        {
            // For simplicity, let's say that movies are similar if they have the same genre.
            List<Movie> recommendedMovies = new List<Movie>();
            foreach (Movie movie in allMovies)
            {
                // Check if the movie has the same genre as any of the user's favorite movies
                if (user.FavoriteMovies.Any(favoriteMovie => favoriteMovie.Genre == movie.Genre && !user.FavoriteMovies.Contains(movie) && !recommendedMovies.Contains(movie)))
                {
                    recommendedMovies.Add(movie);
                    if (recommendedMovies.Count == 5) return recommendedMovies;
                }
            }
            return recommendedMovies;
        }
    }
}
