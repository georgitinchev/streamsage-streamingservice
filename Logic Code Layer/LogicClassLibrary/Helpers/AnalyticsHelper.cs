using DTOs;
using LogicClassLibrary.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Helpers
{
    public static class AnalyticsHelper
    {
        public static double CalculateAverageRating(IMovieService movieService, int movieId)
        {
            // Implementation...
            throw new NotImplementedException();
        }

        public static List<MovieDTO> GetTopRatedMovies(IMovieService movieService)
        {
            // Implementation...
            throw new NotImplementedException();
        }

        public static List<UserDTO> GetMostActiveUsers(IUserService userService)
        {
            // Implementation...
            throw new NotImplementedException();
        }

        public static List<MovieDTO> GetMostReviewedMovies(IMovieService movieService)
        {
            // Implementation...
            throw new NotImplementedException();
        }

        public static Dictionary<DateTime, int> GetUserActivityOverTime(IUserService userService, int userId)
        {
            // Implementation...
            throw new NotImplementedException();
        }

        public static Dictionary<DateTime, int> GetMoviePopularityOverTime(IMovieService movieService, int movieId)
        {
            // Implementation...
            throw new NotImplementedException();
        }
    }
}
