using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IInterpretationManager
    {
        Interpretation TransformDTOToEntity(InterpretationDTO dto);
        InterpretationDTO TransformEntityToDTO(Interpretation entity);
        List<InterpretationDTO> GetAllInterpretations();
        void Create(InterpretationDTO dto);
        InterpretationDTO Read(int id);
        void Update(InterpretationDTO dto);
        void Delete(int id);
        List<InterpretationDTO> GetPaginatedInterpretations(int pageNumber, int pageSize);
        int GetTotalInterpretationsCount();
        List<InterpretationDTO> GetInterpretationsByMovieId(int movieId);
    }
}
