using DTOs;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Managers;
using Microsoft.AspNetCore.Mvc;
using LogicClassLibrary.Managers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    public class LibraryModel : PageModel
    {
        private IWebController webController;
        public List<MovieDTO>? FeaturedMovies { get; private set; }
        public List<MovieDTO>? RandomMovies { get; private set; }
        public List<MovieDTO>? UsageBasedMovies { get; private set; } 
        public string? ErrorMessage { get; private set; }

        public LibraryModel(IWebController webController)
        {
            this.webController = webController;
        }

        public async Task OnGet()
        {
            try
            {
                FeaturedMovies = webController.MovieService.GetMoviesPage(4,8); // Fetch first 5 movies as featured
                RandomMovies = webController.MovieService.GetMoviesPage(5, 8); // Fetch 5 random movies
                UsageBasedMovies = webController.MovieService.GetMoviesPage(6, 8); // Fetch 5 movies based on user behavior
            }
            catch (System.Exception e)
            {
                ErrorMessage = "An error occurred while loading the movies: " + e.Message;
            }
        }
    }
}
