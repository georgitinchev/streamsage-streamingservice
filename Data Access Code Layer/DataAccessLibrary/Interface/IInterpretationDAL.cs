using DTOs;

namespace DataAccessLibrary
{
    public interface IInterpretationDAL
    {
        List<InterpretationDTO> ReadAllInterpretations();
        void CreateInterpretation(InterpretationDTO interpretation);
        InterpretationDTO ReadInterpretation(int interpretationId);
        void UpdateInterpretation(InterpretationDTO interpretation);
        void DeleteInterpretation(int interpretationId);
        int GetTotalInterpretationsCount();
        List<InterpretationDTO> GetPaginatedInterpretations(int pageNumber, int pageSize);
        List<InterpretationDTO> GetInterpretationsByMovieId(int movieId);
        InterpretationDTO GetInterpretationById(int id);
    }
}
