using DTOs;
using LogicClassLibrary.Exceptions;
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
        // Types of movies
        public List<MovieDTO>? FeaturedMovies { get; private set; }
        public List<MovieDTO>? RandomMovies { get; private set; }
        public List<MovieDTO>? UsageBasedMovies { get; private set; }
        public List<MovieDTO>? ContinueWatching { get; private set; }
        // Genres
        public List<string>? AllGenres { get; private set; } = new List<string>();
        public string? SelectedGenre { get; private set; }

        public LibraryModel(IWebController webController)
        {
            this.webController = webController;
        }

        // On get search view data stores search query and genre from layout page
        public void OnGet(string searchQuery = "", string genre = "")
         {
            ModelState.Clear();
            try
            {
                string username = User?.Identity?.Name ?? webController.GetDefaultUser();
				ViewData["AllGenres"] = webController.MovieService.GetAllGenres();
                ViewData["SelectedGenre"] = genre;
				if (!string.IsNullOrEmpty(searchQuery) || !string.IsNullOrEmpty(genre))
                {
                    FeaturedMovies = webController.MovieService.SearchMovies(searchQuery, genre);
                    ClearOtherMovieLists();
                }
                else
                {
                    // Existing code to load movies for other categories
                    FeaturedMovies = webController.RecommendationService.RecommendMoviesForUser(username, 8, RecommendationType.ContentBased);
                    RandomMovies = webController.MovieService.GetMoviesPage(12, 8);
                    UsageBasedMovies = webController.RecommendationService.RecommendMoviesForUser(username, 8, RecommendationType.BehaviorBased);
                    ContinueWatching = webController.GetMoviesByIds(webController.UserService.Read(username).RecentlyWatchedMovieIds)?.Take(8).ToList();
                }
            }
            catch (SearchCriteriaError e)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while loading the movies: " + e.Message);
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

        private void ClearOtherMovieLists()
        {
            RandomMovies = null;
            UsageBasedMovies = null;
            ContinueWatching = null;
        }
    }
}
