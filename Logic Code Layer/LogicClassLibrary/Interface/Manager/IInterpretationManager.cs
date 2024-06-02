using DTOs;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IInterpretationManager 
    {
        Interpretation TransformDTOToEntity(InterpretationDTO dto);
        InterpretationDTO TransformEntityToDTO(Interpretation entity);
        void Create(InterpretationDTO dto);
        InterpretationDTO Read(int id);
        void Update(InterpretationDTO dto);
        void Delete(int id);
    }
}
