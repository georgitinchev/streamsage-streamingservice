using DTOs;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;

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
            return reviewManager.GetAllReviews();
        }
        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
        {
            return reviewManager.GetReviewsPage(pageNumber, pageSize);
        }

        public void AddReview(ReviewDTO review)
        {
            reviewManager.Create(review);
        }

        public ReviewDTO GetReview(int id)
        {
            return reviewManager.Read(id);
        }

        public void UpdateReview(ReviewDTO review)
        {
            reviewManager.Update(review);
        }

        public void DeleteReview(int id)
        {
            reviewManager.Delete(id);
        }

        public int GetTotalReviews()
        {
            return reviewManager.GetTotalReviews();
        }
    }
}
