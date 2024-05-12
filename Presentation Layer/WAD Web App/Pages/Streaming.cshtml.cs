using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicClassLibrary;
using LogicClassLibrary.Entities; // Assuming this namespace contains the Movie class

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class StreamingModel : PageModel
    {
        private WebController webController;
        public StreamingModel(WebController webController)
        {
            this.webController = webController;
        }

        public Movie? MovieDetails { get; private set; }

        public IActionResult OnGet(int movieId)
        {
            MovieDetails = webController.backendService.GetMovie(movieId);
            if (MovieDetails == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
