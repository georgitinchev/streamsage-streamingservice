using DTOs;
using LogicClassLibrary.Exceptions;
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

        public IActionResult OnPostRemoveFromWatchlist(int movieId)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                _webController.UserService.RemoveFromWatchlist(userId, movieId);
                return RedirectToPage();
            }
            catch (UserServiceException ex)
            {
                TempData["ErrorMessage"] = $"Failed to remove movie from watchlist. {ex.Message}";
                return Page();
            }
        }

        public IActionResult OnPostRemoveFromFavorites(int movieId)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                _webController.UserService.RemoveFromFavorites(userId, movieId);
                return RedirectToPage();
            }
            catch (UserServiceException ex)
            {
                TempData["ErrorMessage"] = $"Failed to remove movie from favorites. {ex.Message}";
                return Page();
            }
        }
    }
}
