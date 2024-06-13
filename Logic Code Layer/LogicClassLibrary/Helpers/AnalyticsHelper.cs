using DTOs;
using System.Collections.Generic;
using System.Linq;

namespace LogicClassLibrary.Helpers
{
    public static class AnalyticsHelper
    {
        public static List<MovieDTO> GetTopRatedMovies(List<MovieDTO> allMovies)
        {
            return allMovies
                .Where(m => m.AverageRating.HasValue)
                .OrderByDescending(m => m.AverageRating)
                .Take(10)
                .ToList();
        }

        public static List<MovieDTO> GetLongestRunningMovies(List<MovieDTO> allMovies)
        {
            return allMovies
                .OrderByDescending(m => m.RuntimeMinutes)
                .Take(10)
                .ToList();
        }

        public static List<MovieDTO> GetMostRecentMovies(List<MovieDTO> allMovies)
        {
            return allMovies
                .OrderByDescending(m => m.ReleaseDate)
                .Take(10)
                .ToList();
        }

        public static List<UserDTO> GetMostRecentUsers(List<UserDTO> allUsers)
        {
            return allUsers
                .OrderByDescending(u => u.Id)
                .Take(10)
                .ToList();
        }
    }
}
