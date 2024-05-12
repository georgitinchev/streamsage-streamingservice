using DTOs;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    public class LibraryModel : PageModel
    {
        private WebController webController;
        public List<Movie>? FeaturedMovies { get; private set; }
        public List<Movie>? RandomMovies { get; private set; }
        public List<MovieDTO>? UsageBasedMovies { get; private set; } = new List<MovieDTO>();
        public string? ErrorMessage { get; private set; }

        public LibraryModel(WebController webController)
        {
            this.webController = webController;
        }

        public async Task OnGet()
        {
            try
            {
                FeaturedMovies = webController.backendService.GetFeaturedMovies(); 
                RandomMovies = webController.backendService.GetRandomMovies();
                if (webController.loggedInUser != null)
                {
                    UsageBasedMovies = await webController.backendService.recommendationManager.RecommendMoviesForUser(webController.loggedInUser.Username, 5, RecommendationManager.RecommendationType.BehaviorBased) ?? new List<MovieDTO>();
                }
            }
            catch (Exception e)
            {
                ErrorMessage = "An error occurred while loading the movies: " + e.Message;
            }
        }
    }
}
