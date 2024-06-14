using DTOs;
using LogicClassLibrary.Service_Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    public class LeaderboardsModel : PageModel
    {
        public List<MovieDTO> TopRatedMovies { get; private set; } = new List<MovieDTO>();
        public IWebController webController { get; private set; }
        public LeaderboardsModel(IWebController webController)
        {
            this.webController = webController;
        }
        public void OnGet()
        {
            TopRatedMovies = webController.MovieService.GetTopRatedMovies(50);
        }
    }
}
