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
		public string ErrorMessage { get; private set; }
		public void OnGet()
		{
			try
			{
				List<Movie> movies = webController.displayMoviePage();
				FeaturedMovies = movies.GetRange(0, 5);
				RandomMovies = movies.GetRange(5, 5);
				UsageBasedMovies = movies.GetRange(10, 5);
			}
			catch (Exception e)
			{
				ErrorMessage = "An error occured while loading the movies" + e.Message;
			}
		}
	}
}
