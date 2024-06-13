using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Exceptions; // Add this line

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
            try
            {
                return reviewDAL.ReadAllReviews();
            }
            catch (Exception ex)
            {
                throw new GetAllEntitiesError(ex.Message, ex);
            }
        }

        public override void Create(ReviewDTO dto)
        {
            try
            {
                reviewDAL.CreateReview(dto);
            }
            catch (Exception ex)
            {
                throw new CreateEntityError(ex.Message, ex);
            }
        }

        public override ReviewDTO Read(int id)
        {
            try
            {
                return reviewDAL.ReadReview(id);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public override void Update(ReviewDTO dto)
        {
            try
            {
                reviewDAL.UpdateReview(dto);
            }
            catch (Exception ex)
            {
                throw new UpdateEntityError(ex.Message, ex);
            }
        }

        public override void Delete(int id)
        {
            try
            {
                reviewDAL.DeleteReview(id);
            }
            catch (Exception ex)
            {
                throw new DeleteEntityError(ex.Message, ex);
            }
        }

        public List<ReviewDTO> GetReviewsByMovieId(int movieId)
        {
            try
            {
                return reviewDAL.GetReviewsByMovieId(movieId);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public int GetTotalReviews()
        {
            try
            {
                return reviewDAL.GetTotalReviews();
            }
            catch (Exception ex)
            {
                throw new GetTotalEntitiesError(ex.Message, ex);
            }
        }

        public List<ReviewDTO> GetReviewsPage(int pageNumber, int pageSize)
        {
            try
            {
                return reviewDAL.GetReviewsPage(pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                throw new PaginatorException(ex.Message, ex);
            }
        }

        public override Review? TransformDTOToEntity(ReviewDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    return null;
                }

                return new Review(dto.Id, dto.UserId, dto.MovieId, dto.Title ?? string.Empty, dto.Content ?? string.Empty, dto.Rating);
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }

        public override ReviewDTO TransformEntityToDTO(Review entity)
        {
            try
            {
                if (entity == null)
                {
                    return null!;
                }

                return new ReviewDTO(entity.Id, entity.UserId, entity.MovieId, entity.Title, entity.Content, entity.Rating, entity.ReviewDate);
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }
    }
}
