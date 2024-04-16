using LogicClassLibrary;
using LogicClassLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    public class LibraryModel : PageModel
    {
        private WebController webController = new WebController();
        public List<Movie>? FeaturedMovies { get; private set; }
        public List<Movie>? RandomMovies { get; private set; }
        public List<Movie>? UsageBasedMovies { get; private set; }
		public void OnGet()
		{

			var allMovies = webController.BrowseMovies().ToList();
		}
	}
}
