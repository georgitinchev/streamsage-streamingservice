using DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamSageWAD.Exception;
using System.Security.Claims;

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private IWebController _webController;
        public List<MovieDTO> RecentlyWatchedMovies { get; private set; }
        public List<MovieDTO> Watchlist { get; private set; }
        public List<MovieDTO> Favorites { get; private set; }
        public List<string> FavoriteGenres { get; private set; }
        public ProfileModel(IWebController webController)
        {
            _webController = webController;
            RecentlyWatchedMovies = new List<MovieDTO>();
            Watchlist = new List<MovieDTO>();
            Favorites = new List<MovieDTO>();
            FavoriteGenres = new List<string>();
        }

        public void OnGet()
        {
            try
            {
                var user = _webController.UserService.Read(int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
                RecentlyWatchedMovies = _webController.GetMoviesByIds(user.RecentlyWatchedMovieIds);
                Watchlist = user.WatchList;
                Favorites = user.FavoriteMovies;
            }
            catch (MovieNotFoundException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = $"An unexpected error occurred. {ex.Message}";
            }
        }
    }
}
