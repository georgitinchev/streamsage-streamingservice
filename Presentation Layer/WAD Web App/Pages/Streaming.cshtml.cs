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
            webController.UserService.AddToRecentlyWatched(int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), movieId);
            return Page();
        }

        public IActionResult OnPostSubmitReview()
        {
            if (!ModelState.IsValid)
            {
                PopulatePageData(CurrentMovieId);
                return Page();
            }

            Review.MovieId = CurrentMovieId; // Ensure the correct MovieId is set
            webController.ReviewService.AddReview(new ReviewDTO(
                0, int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), CurrentMovieId,
                Review.Title, Review.Content, Review.Rating, DateTime.Now));

            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        public IActionResult OnPostEditReview(int reviewId, string updatedTitle, string updatedContent, int updatedRating)
        {
            var review = webController.ReviewService.GetReview(reviewId);
            if (review == null)
            {
                ModelState.AddModelError("", "Review not found.");
                return Page();
            }

            webController.ReviewService.UpdateReview(new ReviewDTO(
                reviewId, review.UserId, CurrentMovieId, updatedTitle, updatedContent, updatedRating, review.ReviewDate));

            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        public IActionResult OnPostDeleteReview(int reviewId)
        {
            webController.ReviewService.DeleteReview(reviewId);
            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        public IActionResult OnPostSubmitInterpretation()
        {
            if (!ModelState.IsValid)
            {
                PopulatePageData(CurrentMovieId);
                return Page();
            }

            Interpretation.MovieId = CurrentMovieId; // Ensure the correct MovieId is set
            webController.InterpretationService.AddInterpretation(new InterpretationDTO(
                0, int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)), CurrentMovieId,
                Interpretation.InterpretationText, DateTime.Now));

            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        public IActionResult OnPostEditInterpretation(int interpretationId, string updatedInterpretationText)
        {
            var interpretation = webController.InterpretationService.GetInterpretationById(interpretationId);
            if (interpretation == null)
            {
                ModelState.AddModelError("", "Interpretation not found.");
                return Page();
            }

            interpretation.InterpretationText = updatedInterpretationText;
            webController.InterpretationService.UpdateInterpretation(interpretation);

            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        public IActionResult OnPostDeleteInterpretation(int interpretationId)
        {
            webController.InterpretationService.DeleteInterpretation(interpretationId);
            return RedirectToPage(new { movieId = CurrentMovieId });
        }

        // OnPost method for toggling the watchlist
        public IActionResult OnPostToggleWatchlist(int movieId)
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

        // OnPost method for toggling the favorites
        public IActionResult OnPostToggleFavorites(int movieId)
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
    }
}
