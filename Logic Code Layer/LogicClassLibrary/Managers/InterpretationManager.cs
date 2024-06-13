using DataAccessLibrary;
using DTOs;
using LogicClassLibrary.Entities;
using LogicClassLibrary.Exceptions;
using LogicClassLibrary.Interface.Manager;
using System;

namespace LogicClassLibrary.Managers
{
    public class InterpretationManager : GeneralManager<InterpretationDTO, Interpretation>, IInterpretationManager
    {
        private IInterpretationDAL interpretationDAL;
        private IUserDAL userDAL;
        private IMovieDAL movieDAL;

        public InterpretationManager(IInterpretationDAL _interpretationDAL, IUserDAL _userDAL, IMovieDAL _movieDAL)
        {
            this.interpretationDAL = _interpretationDAL;
            this.userDAL = _userDAL;
            this.movieDAL = _movieDAL;
        }

        public List<InterpretationDTO> GetAllInterpretations()
        {
            try
            {
                return interpretationDAL.ReadAllInterpretations();
            }
            catch (Exception ex)
            {
                throw new GetAllEntitiesError(ex.Message, ex);
            }
        }

        public override void Create(InterpretationDTO dto)
        {
            try
            {
                var entity = TransformDTOToEntity(dto);
                if (entity != null)
                {
                    // Check if the user exists
                    if (userDAL?.GetUserById(dto.UserId) == null)
                    {
                        throw new CreateEntityError("User does not exist");
                    }

                    // Check if the movie exists
                    if (movieDAL?.MovieExists(dto.MovieId) == null)
                    {
                        throw new CreateEntityError("Movie does not exist");
                    }

                    interpretationDAL.CreateInterpretation(dto);
                }
            }
            catch (Exception ex)
            {
                throw new CreateEntityError(ex.Message, ex);
            }
        }

        public override InterpretationDTO Read(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ReadEntityError("Interpretation ID must be greater than zero");
                }

                return interpretationDAL.ReadInterpretation(id);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public override void Update(InterpretationDTO dto)
        {
            try
            {
                if (dto.Id <= 0)
                {
                    throw new UpdateEntityError("Interpretation ID must be greater than zero");
                }

                var entity = TransformDTOToEntity(dto);
                if (entity != null)
                {
                    interpretationDAL.UpdateInterpretation(dto);
                }
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
                if (id <= 0)
                {
                    throw new DeleteEntityError();
                }

                interpretationDAL.DeleteInterpretation(id);
            }
            catch (Exception ex)
            {
                throw new DeleteEntityError(ex.Message, ex);
            }
        }

        public List<InterpretationDTO> GetPaginatedInterpretations(int pageNumber, int pageSize)
        {
            try
            {
                if (pageNumber <= 0)
                {
                    throw new PaginatorException("Page number must be greater than zero");
                }

                if (pageSize <= 0)
                {
                    throw new PaginatorException("Page size must be greater than zero");
                }

                return interpretationDAL.GetPaginatedInterpretations(pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                throw new PaginatorException(ex.Message, ex);
            }
        }

        public int GetTotalInterpretationsCount()
        {
            try
            {
                return interpretationDAL.GetTotalInterpretationsCount();
            }
            catch (Exception ex)
            {
                throw new GetTotalEntitiesError(ex.Message, ex);
            }
        }

        // Get all interpretations by movie ID
        public List<InterpretationDTO> GetInterpretationsByMovieId(int movieId)
        {
            try
            {
                if (movieId <= 0)
                {
                    throw new ReadEntityError("Movie ID must be greater than zero");
                }

                return interpretationDAL.GetInterpretationsByMovieId(movieId);
            }
            catch (Exception ex)
            {
                throw new ReadEntityError(ex.Message, ex);
            }
        }

        public override Interpretation? TransformDTOToEntity(InterpretationDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    throw new TransformationException("DTO cannot be null.");
                }

                if (string.IsNullOrWhiteSpace(dto.InterpretationText))
                {
                    throw new TransformationException("Interpretation text cannot be empty");
                }

                return new Interpretation(dto.UserId, dto.MovieId, dto.InterpretationText);
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }

        public override InterpretationDTO TransformEntityToDTO(Interpretation entity)
        {
            try
            {
                return new InterpretationDTO(entity.Id, entity.UserId, entity.MovieId, entity.InterpretationText, entity.InterpretationDate);
            }
            catch (Exception ex)
            {
                throw new TransformationException(ex.Message, ex);
            }
        }
    }
}
