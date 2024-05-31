namespace LogicClassLibrary.Interface.Manager
{
    public interface IInterpretationManager : IGeneralManager
    {
        void createInterpretation(int userId, int movieId, string interpretationText);
        void updateInterpretation(int interpretationId, string interpretationText);
        void deleteInterpretation(int interpretationId);
    }
}
