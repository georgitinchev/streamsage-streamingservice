using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;

namespace LogicClassLibrary.Managers
{
    public class ReviewManager : GeneralManager<ReviewDTO, Review>, IReviewManager
    {
        private IReviewDAL reviewDAL;

        public ReviewManager(IReviewDAL _reviewDAL)
        {
            reviewDAL = _reviewDAL;
        }

        public List<ReviewDTO> GetAllReviews()
        {
            return reviewDAL.ReadAllReviews();
        }

        public override void Create(ReviewDTO dto)
        {
            reviewDAL.CreateReview(dto);
        }

        public override ReviewDTO Read(int id)
        {
            return reviewDAL.ReadReview(id);
        }

        public override void Update(ReviewDTO dto)
        {
            reviewDAL.UpdateReview(dto);
        }

        public override void Delete(int id)
        {
            reviewDAL.DeleteReview(id);
        }

        public int GetTotalReviews()
        {
            return reviewDAL.GetTotalReviews();
        }

        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
        {
            return reviewDAL.GetReviewsPage(pageNumber, pageSize);
        }

        public override Review? TransformDTOToEntity(ReviewDTO dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Review(dto.Id, dto.UserId, dto.MovieId, dto.Title ?? string.Empty, dto.Content ?? string.Empty, dto.Rating);
        }

        public override ReviewDTO TransformEntityToDTO(Review entity)
        {
            if (entity == null)
            {
                return null!;
            }

            return new ReviewDTO(entity.Id, entity.UserId, entity.MovieId, entity.Title, entity.Content, entity.Rating, entity.ReviewDate);
        }
    }
}