using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using DTOs;

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class StreamingModel : PageModel
    {
        private IWebController webController;
        public StreamingModel(IWebController webController)
        {
            this.webController = webController;
        }
        public MovieDTO? MovieDetails { get; private set; }
        public IActionResult OnGet(int movieId)
        {
            MovieDetails = webController.MovieService.GetMovie(movieId);
            if (MovieDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
