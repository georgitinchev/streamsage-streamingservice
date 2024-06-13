using DTOs;

namespace LogicClassLibrary.Interface.Service
{
    public interface IInterpretationService
    {
        List<InterpretationDTO> GetInterpretationsPage(int pageNumber, int pageSize);
        void AddInterpretation(InterpretationDTO interpretation);
        void UpdateInterpretation(InterpretationDTO interpretation);
        void DeleteInterpretation(int id);
        List<InterpretationDTO> GetAllInterpretations();
        int GetTotalInterpretationsCount();
        List<InterpretationDTO> GetInterpretationsByMovieId(int movieId);
        InterpretationDTO GetInterpretationById(int id);
    }
}
