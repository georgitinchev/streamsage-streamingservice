using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Exceptions;
using System;

namespace LogicClassLibrary.Service_Classes
{
    public class ReviewService : IReviewService
    {
        private IReviewManager reviewManager;

        public ReviewService(IReviewManager _reviewManager)
        {
            reviewManager = _reviewManager;
        }

        public List<ReviewDTO> GetAllReviews()
        {
            try
            {
                return reviewManager.GetAllReviews();
            }
            catch (Exception ex)
            {
                throw new GetAllReviewsError("Error getting all reviews", ex);
            }
        }

        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
        {
            try
            {
                return reviewManager.GetReviewsPage(pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                throw new GetReviewsPageError($"Error getting reviews page {pageNumber}", ex);
            }
        }

        public List<ReviewDTO> GetReviewsByMovieId(int movieId)
        {
            try
            {
                return reviewManager.GetReviewsByMovieId(movieId);
            }
            catch (Exception ex)
            {
                throw new GetReviewsByMovieIdError($"Error getting reviews for movie {movieId}", ex);
            }
        }

        public void AddReview(ReviewDTO review)
        {
            try
            {
                reviewManager.Create(review);
            }
            catch (Exception ex)
            {
                throw new CreateReviewError("Error adding review", ex);
            }
        }

        public ReviewDTO GetReview(int id)
        {
            try
            {
                return reviewManager.Read(id);
            }
            catch (Exception ex)
            {
                throw new ReadReviewError($"Error reading review {id}", ex);
            }
        }

        public void UpdateReview(ReviewDTO review)
        {
            try
            {
                reviewManager.Update(review);
            }
            catch (Exception ex)
            {
                throw new UpdateReviewError("Error updating review", ex);
            }
        }

        public void DeleteReview(int id)
        {
            try
            {
                reviewManager.Delete(id);
            }
            catch (Exception ex)
            {
                throw new DeleteReviewError($"Error deleting review {id}", ex);
            }
        }

        public int GetTotalReviews()
        {
            try
            {
                return reviewManager.GetTotalReviews();
            }
            catch (Exception ex)
            {
                throw new GetTotalReviewsError("Error getting total reviews", ex);
            }
        }
    }
}
