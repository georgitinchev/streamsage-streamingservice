using DTOs;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class Analytics : Form
    {
        public IDesktopController desktopController { get; private set; }

        public Analytics(IDesktopController _desktopController)
        {
            InitializeComponent();
            this.desktopController = _desktopController;
            PopulateAnalytics();
        }

        private void PopulateAnalytics()
        {
            int pageSize = desktopController.GetPageSize();
            int totalMovies = desktopController.GetTotalMovies();
            int totalPages = (int)Math.Ceiling(totalMovies / (double)pageSize);
            List<MovieDTO> selectedMovies = new List<MovieDTO>();

            for (int pageNumber = 1; pageNumber <= totalPages; pageNumber++)
            {
                var moviesPage = desktopController.GetMoviesPage(pageNumber, pageSize);
                selectedMovies.AddRange(moviesPage);
              
            }

            var topRatedMovies = AnalyticsHelper.GetTopRatedMovies(selectedMovies);
            var longestRunningMovies = AnalyticsHelper.GetLongestRunningMovies(selectedMovies);
            var mostRecentMovies = AnalyticsHelper.GetMostRecentMovies(selectedMovies);

            var allUsers = desktopController.UserService.GetAllUsers(); 
            var mostRecentUsers = AnalyticsHelper.GetMostRecentUsers(allUsers);

            UIStyler.PopulateListOrPlaceholder(topRatedMoviesList, topRatedMovies.Select(m => $"{m.Title} ({m.AverageRating})"), "No top-rated movies found");
            UIStyler.PopulateListOrPlaceholder(longestRunningMoviesList, longestRunningMovies.Select(m => $"{m.Title} ({m.RuntimeMinutes} mins)"), "No longest-running movies found");
            UIStyler.PopulateListOrPlaceholder(mostRecentMoviesList, mostRecentMovies.Select(m => $"{m.Title} ({m.ReleaseDate.ToShortDateString()})"), "No recent movies found");
            UIStyler.PopulateListOrPlaceholder(mostRecentUsersList, mostRecentUsers.Select(u => $"{u.Username} (ID: {u.Id})"), "No recent users found");
        }
    }
}
