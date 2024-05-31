using DTOs;

namespace DataAccessLibrary
{
    public interface IReviewDAL
    {
        void ReadAllReviews();
        void CreateReview(ReviewDTO review);
        ReviewDTO ReadReview(int reviewId);
        void UpdateReview(ReviewDTO review);
        void DeleteReview(int reviewId);
    }
}
