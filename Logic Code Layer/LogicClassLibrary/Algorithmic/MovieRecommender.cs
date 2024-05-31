using DataAccessLibrary.DataAccessLibrary;
using DTOs;

namespace LogicClassLibrary.Managers
{
    public class MovieRecommender
    {
        private readonly UserDAL userDAL;

        public MovieRecommender(UserDAL userDAL)
        {
            this.userDAL = userDAL;
        }

        // Recommends movies based on user behavior
        public List<MovieDTO> RecommendMoviesBasedOnUserBehavior(string username, List<MovieDTO> allMovies)
        {
            UserDTO user = userDAL.GetUserByUsername(username);
            if (user == null) return new List<MovieDTO>();

            List<MovieDTO> userFavoriteMovies = user.FavoriteMovies ?? new List<MovieDTO>();
            Dictionary<MovieDTO, int> movieScores = new Dictionary<MovieDTO, int>();
            allMovies.ForEach(movie => movieScores.Add(movie, 0));

            foreach (UserDTO otherUser in userDAL.ReadAllUsers().Where(u => u.Username != username))
            {
                var otherUserFavoriteMovies = otherUser.FavoriteMovies ?? new List<MovieDTO>();
                int similarityScore = otherUserFavoriteMovies.Intersect(userFavoriteMovies, new MovieDTOComparer()).Count();
                foreach (MovieDTO movie in otherUserFavoriteMovies)
                {
                    if (movieScores.ContainsKey(movie))
                    {
                        movieScores[movie] += similarityScore;
                    }
                }
            }

            return movieScores.OrderByDescending(pair => pair.Value)
                              .Select(pair => pair.Key)
                              .Take(5)
                              .ToList();
        }

        // Recommends movies based on content
        public List<MovieDTO> RecommendMoviesBasedOnContent(string username, List<MovieDTO> allMovies, int numRecommendations = 5)
        {
            UserDTO user = userDAL.GetUserByUsername(username);
            if (user == null || user.FavoriteMovies == null) return new List<MovieDTO>();

            HashSet<string> favoriteGenres = new HashSet<string>(user.FavoriteMovies.SelectMany(m => m.Genres ?? Enumerable.Empty<string>()));
            var moviesWithGenreMatchCount = allMovies.Select(movie => new
            {
                Movie = movie,
                MatchCount = movie.Genres != null ? movie.Genres.Count(genre => favoriteGenres.Contains(genre)) : 0
            }).ToList();

            var recommendedMovies = moviesWithGenreMatchCount.Where(x => x.MatchCount >= 2)
                                                             .Select(x => x.Movie)
                                                             .Take(numRecommendations)
                                                             .ToList();

            if (recommendedMovies.Count < numRecommendations)
            {
                recommendedMovies.AddRange(moviesWithGenreMatchCount.Where(x => x.MatchCount == 1)
                                                                     .Select(x => x.Movie)
                                                                     .Take(numRecommendations - recommendedMovies.Count));
            }

            return recommendedMovies;
        }

        private class MovieDTOComparer : IEqualityComparer<MovieDTO>
        {
            public bool Equals(MovieDTO x, MovieDTO y) => x.Id == y.Id;
            public int GetHashCode(MovieDTO obj) => obj.Id.GetHashCode();
        }
    }
}
