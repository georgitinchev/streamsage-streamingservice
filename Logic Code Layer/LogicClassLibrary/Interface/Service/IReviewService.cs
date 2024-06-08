using DTOs;

namespace LogicClassLibrary.Interface.Service
{
    public interface IReviewService
    {
        List<ReviewDTO> GetAllReviews();
        List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize);
        ReviewDTO GetReview(int id);
        void AddReview(ReviewDTO review); 
        void UpdateReview(ReviewDTO review);
        void DeleteReview(int id);
        int GetTotalReviews();
    }
}