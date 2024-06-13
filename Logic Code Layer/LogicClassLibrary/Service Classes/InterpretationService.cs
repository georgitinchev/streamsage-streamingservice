using DTOs;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Interface.Manager;
using System.Collections.Generic;
using LogicClassLibrary.Exceptions;
using System;

namespace LogicClassLibrary.Service_Classes
{
    public class InterpretationService : IInterpretationService
    {
        private readonly IInterpretationManager interpretationManager;

        public InterpretationService(IInterpretationManager _interpretationManager)
        {
            this.interpretationManager = _interpretationManager;
        }

        public List<InterpretationDTO> GetInterpretationsPage(int pageNumber, int pageSize)
        {
            try
            {
                return interpretationManager.GetPaginatedInterpretations(pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                throw new GetInterpretationsPageError($"Error getting interpretations page {pageNumber}", ex);
            }
        }

        public List<InterpretationDTO> GetAllInterpretations()
        {
            try
            {
                return interpretationManager.GetAllInterpretations();
            }
            catch (Exception ex)
            {
                throw new GetAllInterpretationsError("Error getting all interpretations", ex);
            }
        }

        public void AddInterpretation(InterpretationDTO interpretation)
        {
            try
            {
                interpretationManager.Create(interpretation);
            }
            catch (Exception ex)
            {
                throw new CreateInterpretationError("Error adding interpretation", ex);
            }
        }

        public void UpdateInterpretation(InterpretationDTO interpretation)
        {
            try
            {
                interpretationManager.Update(interpretation);
            }
            catch (Exception ex)
            {
                throw new UpdateInterpretationError("Error updating interpretation", ex);
            }
        }

        public void DeleteInterpretation(int id)
        {
            try
            {
                interpretationManager.Delete(id);
            }
            catch (Exception ex)
            {
                throw new DeleteInterpretationError($"Error deleting interpretation {id}", ex);
            }
        }

        public InterpretationDTO GetInterpretationById(int id)
        {
            try
            {
                return interpretationManager.Read(id);
            }
            catch (Exception ex)
            {
                throw new ReadInterpretationError($"Error reading interpretation {id}", ex);
            }
        }

        public int GetTotalInterpretationsCount()
        {
            try
            {
                return interpretationManager.GetTotalInterpretationsCount();
            }
            catch (Exception ex)
            {
                throw new GetTotalInterpretationsError("Error getting total interpretations count", ex);
            }
        }

        public List<InterpretationDTO> GetInterpretationsByMovieId(int movieId)
        {
            try
            {
                return interpretationManager.GetInterpretationsByMovieId(movieId);
            }
            catch (Exception ex)
            {
                throw new GetInterpretationsByMovieIdError($"Error getting interpretations for movie {movieId}", ex);
            }
        }
    }
}
