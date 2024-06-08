using DTOs;

namespace DataAccessLibrary
{
    public interface IReviewDAL
    {
        List<ReviewDTO> ReadAllReviews();
        void CreateReview(ReviewDTO review);
        ReviewDTO ReadReview(int reviewId);
        void UpdateReview(ReviewDTO review);
        void DeleteReview(int reviewId);
        List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize);
        int GetTotalReviews();
    }
}
