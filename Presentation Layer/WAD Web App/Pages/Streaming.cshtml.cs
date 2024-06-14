using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicClassLibrary;
using LogicClassLibrary.Entities;
using DTOs;
using System.Collections.Generic;
using StreamSageWAD.Models;
using System.Linq;
using System.Security.Claims;
using LogicClassLibrary.Exceptions;

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class StreamingModel : PageModel
    {
        private IWebController webController;
        [BindProperty]
        public ReviewModelDTO Review { get; set; }
        [BindProperty]
        public InterpretationModelDTO Interpretation { get; set; }
        public int CurrentMovieId { get; set; }
        public StreamingViewModel ViewModel { get; private set; }

        public StreamingModel(IWebController webController)
        {
            this.webController = webController;
            ViewModel = new StreamingViewModel();
        }

        private void PopulatePageData(int movieId)
        {
            ViewModel.MovieDetails = webController.MovieService.GetMovie(movieId);
            if (ViewModel.MovieDetails != null)
            {
                CurrentMovieId = ViewModel.MovieDetails.Id;
                UserDTO user = webController.UserService.Read(User.Identity.Name);
                if (user != null)
                {
                    var allReviews = webController.ReviewService.GetReviewsByMovieId(CurrentMovieId);
                    var allInterpretations = webController.InterpretationService.GetInterpretationsByMovieId(CurrentMovieId);
                    ViewModel.UserReviews = allReviews.Where(r => r.UserId == user.Id).ToList();
                    ViewModel.OtherReviews = allReviews.Except(ViewModel.UserReviews).ToList();
                    ViewModel.UserInterpretations = allInterpretations.Where(i => i.UserId == user.Id).ToList();
                    ViewModel.OtherInterpretations = allInterpretations.Except(ViewModel.UserInterpretations).ToList();
                    ViewModel.UserWatchList = user.WatchList?.Select(w => w.Id).ToList() ?? new List<int>();
                    ViewModel.UserFavorites = user.FavoriteMovies?.Select(f => f.Id).ToList() ?? new List<int>();
                }
            }
        }

        public IActionResult OnGet(int movieId)
        {
            PopulatePageData(movieId);
            if (ViewModel.MovieDetails == null)
            {
                return NotFound();
            }
            try
            {
                webController.UserService.AddToRecentlyWatched(int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), movieId);
                return Page();
            }
            catch (UserServiceException ex)
            {
                TempData["ErrorMessage"] = "An error occurred while adding to recently watched: " + ex.Message;
                return RedirectToPage("/Error");
            }
        }

        public IActionResult OnPostSubmitReview(int movieId)
        {
            ModelState.Clear();
            if (!TryValidateModel(Interpretation))
            {
                PopulatePageData(movieId);
                return Page();
            }

            try
            {
                Review.MovieId = movieId;
                webController.ReviewService.AddReview(new ReviewDTO(
                    0, int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), movieId,
                    Review.Title, Review.Content, Review.Rating, DateTime.Now));

                return RedirectToPage(new { movieId });
            }
            catch (CreateReviewError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        public IActionResult OnPostEditReview(int reviewId, string updatedTitle, string updatedContent, int updatedRating, int movieId)
        {
            try
            {
                var review = webController.ReviewService.GetReview(reviewId);
                if (review == null)
                {
                    ModelState.AddModelError("", "Review not found.");
                    PopulatePageData(movieId);
                    return Page();
                }
                webController.ReviewService.UpdateReview(new ReviewDTO(
                    reviewId, review.UserId, movieId, updatedTitle, updatedContent, updatedRating, review.ReviewDate));
                return RedirectToPage(new { movieId = movieId });
            }
            catch (UpdateReviewError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        public IActionResult OnPostDeleteReview(int reviewId, int movieId)
        {
            try
            {
                webController.ReviewService.DeleteReview(reviewId);
                return RedirectToPage(new { movieId = movieId });
            }
            catch (DeleteReviewError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        public IActionResult OnPostSubmitInterpretation(int movieId)
        {
            ModelState.Clear();
            if (!TryValidateModel(Interpretation))
            {
                PopulatePageData(movieId);
                return Page();
            }

            try
            {
                Interpretation.MovieId = movieId;
                webController.InterpretationService.AddInterpretation(new InterpretationDTO(
                    0, int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), movieId,
                    Interpretation.InterpretationText, DateTime.Now));
            }
            catch (CreateInterpretationError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }

            return RedirectToPage(new { movieId = movieId });
        }

        public IActionResult OnPostEditInterpretation(int interpretationId, string updatedInterpretationText, int movieId)
        {
            try
            {
                var interpretation = webController.InterpretationService.GetInterpretationById(interpretationId);
                if (interpretation == null)
                {
                    ModelState.AddModelError("", "Interpretation not found.");
                    PopulatePageData(movieId);
                    return Page();
                }
                interpretation.InterpretationText = updatedInterpretationText;
                webController.InterpretationService.UpdateInterpretation(interpretation);
                return RedirectToPage(new { movieId = movieId });
            }
            catch (UpdateInterpretationError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        public IActionResult OnPostDeleteInterpretation(int interpretationId, int movieId)
        {
            try
            {
                webController.InterpretationService.DeleteInterpretation(interpretationId);
                return RedirectToPage(new { movieId = movieId });
            }
            catch (DeleteInterpretationError ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        // OnPost method for toggling the watchlist
        public IActionResult OnPostToggleWatchlist(int movieId)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                if (ViewModel.UserWatchList.Contains(movieId))
                {
                    webController.UserService.RemoveFromWatchlist(userId, movieId);
                }
                else
                {
                    webController.UserService.AddToWatchlist(userId, movieId);
                }
                return RedirectToPage(new { movieId = movieId });
            }
            catch (UserServiceException ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }

        // OnPost method for toggling the favorites
        public IActionResult OnPostToggleFavorites(int movieId)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                if (ViewModel.UserFavorites.Contains(movieId))
                {
                    webController.UserService.RemoveFromFavorites(userId, movieId);
                }
                else
                {
                    webController.UserService.AddToFavorites(userId, movieId);
                }
                return RedirectToPage(new { movieId = movieId });
            }
            catch (UserServiceException ex)
            {
                ModelState.AddModelError("", ex.Message);
                PopulatePageData(movieId);
                return Page();
            }
        }
    }
}
