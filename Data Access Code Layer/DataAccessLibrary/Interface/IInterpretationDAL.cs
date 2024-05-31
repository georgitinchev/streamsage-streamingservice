using DTOs;

namespace LogicClassLibrary.Interface.DAL
{
    public interface IInterpretationDAL
    {
        void ReadAllInterpretations();
        void CreateInterpretation(InterpretationDTO interpretation);
        InterpretationDTO ReadInterpretation(int interpretationId);
        void UpdateInterpretation(InterpretationDTO interpretation);
        void DeleteInterpretation(int interpretationId);
    }
}
