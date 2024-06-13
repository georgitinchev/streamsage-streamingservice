using DTOs;
using LogicClassLibrary.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamSageWAD.Pages
{
    public class LibraryModel : PageModel
    {
        private readonly IWebController webController;
        public List<MovieDTO>? FeaturedMovies { get; private set; }
        public List<MovieDTO>? RandomMovies { get; private set; }
        public List<MovieDTO>? UsageBasedMovies { get; private set; }
        public List<MovieDTO>? ContinueWatching { get; private set; }
        public string? ErrorMessage { get; private set; }

        public LibraryModel(IWebController webController)
        {
            this.webController = webController;
        }

        public void OnGet()
        {
            try
            {
                // Get the username of the currently logged in user or the default user
                string username = User.Identity.Name ?? webController.GetDefaultUser();
               // Get the movies recommended based on the content
                FeaturedMovies = webController.RecommendationService.RecommendMoviesForUser(username, 8, RecommendationType.ContentBased);
                // Get random moviess
                RandomMovies = webController.MovieService.GetMoviesPage(12, 8);
                // Get the movies recommended based on the user's behavior
                UsageBasedMovies = webController.RecommendationService.RecommendMoviesForUser(username, 8, RecommendationType.BehaviorBased);
                // Get the 8 most recently watched movies
                var recentlyWatchedMovieIds = webController.UserService.Read(username).RecentlyWatchedMovieIds;
                ContinueWatching = webController.GetMoviesByIds(recentlyWatchedMovieIds)?.Take(8).ToList();
            }
            catch (System.Exception e)
            {
                ErrorMessage = "An error occurred while loading the movies: " + e.Message;
            }
        }

        public IActionResult OnGetWatchMovie(int movieId)
        {
            var returnUrl = $"/Streaming?movieId={movieId}";
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Login", new { ReturnUrl = returnUrl, Message = "You need to authenticate before you can watch a movie." });
            }
            return Redirect(returnUrl);
        }
    }
}
