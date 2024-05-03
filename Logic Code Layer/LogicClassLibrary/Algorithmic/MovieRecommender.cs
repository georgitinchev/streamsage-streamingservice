using DataAccessLibrary;
using DataAccessLibrary.DataAccessLibrary;
using DTOs;
using System.Collections.Generic;
using System.Linq;

namespace LogicClassLibrary.Managers
{
    public class MovieRecommender
    {
        private readonly UserDAL userDAL;

        public MovieRecommender(UserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        // filter based on similar users favorite genres
        public List<MovieDTO> RecommendMoviesBasedOnUserBehavior(string username, List<MovieDTO> allMovies)
        {
            UserDTO user = userDAL.GetUserByUsername(username);
            if (user != null)
            {
                List<MovieDTO> userFavoriteMovies = user.FavoriteMovies ?? new List<MovieDTO>();
                Dictionary<MovieDTO, int> movieScores = new Dictionary<MovieDTO, int>();
                foreach (MovieDTO movie in allMovies)
                {
                    movieScores.Add(movie, 0);
                }
                foreach (UserDTO otherUser in userDAL.ReadAllUsers())
                {
                    if (otherUser.Username == username) continue;
                    var otherUserFavoriteMovies = otherUser.FavoriteMovies ?? new List<MovieDTO>();
                    int similarityScore = otherUser.FavoriteMovies.Intersect(userFavoriteMovies).Count();
                    foreach (MovieDTO movie in otherUser.FavoriteMovies)
                    {
                        if (movieScores.ContainsKey(movie))
                        {
                            movieScores[movie] += similarityScore;
                        }
                    }
                }
                // Sort movies by their scores and take the top 5.
                List<MovieDTO> recommendedMovies = movieScores.OrderByDescending(pair => pair.Value)
                                                                .Select(pair => pair.Key)
                                                                .Take(5)
                                                                .ToList();
                return recommendedMovies;
            }
            else
            {
                return new List<MovieDTO>();
            }
        }

        // filter based on genres
        public List<MovieDTO> RecommendMoviesBasedOnContent(string username, List<MovieDTO> allMovies, int numRecommendations = 5)
        {
            UserDTO user = userDAL.GetUserByUsername(username);
            if (user != null && user.FavoriteMovies != null)
            {
                HashSet<string> favoriteGenres = new HashSet<string>(user.FavoriteMovies.SelectMany(m => m.Genres ?? Enumerable.Empty<string>()));
                var moviesWithGenreMatchCount = allMovies.Select(movie => new
                {
                    Movie = movie,
                    MatchCount = movie.Genres != null ? movie.Genres.Count(genre => favoriteGenres.Contains(genre)) : 0
                });
                var recommendedMovies = moviesWithGenreMatchCount.Where(x => x.MatchCount >= 2)
                                                                 .Select(x => x.Movie)
                                                                 .Take(numRecommendations)
                                                                 .ToList();
                if (recommendedMovies.Count < numRecommendations)
                {
                    var additionalMovies = moviesWithGenreMatchCount.Where(x => x.MatchCount == 1)
                                                                    .Select(x => x.Movie)
                                                                    .Take(numRecommendations - recommendedMovies.Count)
                                                                    .ToList();
                    recommendedMovies.AddRange(additionalMovies);
                }

                return recommendedMovies;
            }
            else
            {
                return new List<MovieDTO>();
            }
        }
    }
}
