using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IReviewManager
    {
        List<ReviewDTO> GetAllReviews();
        void Create(ReviewDTO review);
        ReviewDTO Read(int id);
        void Update(ReviewDTO review);
        void Delete(int id);
        List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize);
        int GetTotalReviews();
    }
}
