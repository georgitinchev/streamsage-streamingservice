using DataAccessLibrary;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Managers
{
    public class InterpretationManager
    {
        public List<Interpretation>? interpretations;
        public InterpretationDAL? interpretationDAL;
        public InterpretationManager(InterpretationDAL _interpretationDAL)
        {
            interpretations = new List<Interpretation>();
            interpretationDAL = _interpretationDAL;
        }

        private void createInterpretation(int userId, int movieId, string interpretationText)
        {
            Interpretation interpretation = new Interpretation(userId, movieId, interpretationText);
            interpretations?.Add(interpretation);
        }

        private void updateInterpretation(int interpretationId, string newInterpretationText)
        {
            Interpretation interpretation = interpretations?.Find(i => i.Id == interpretationId);
            if (interpretation != null)
            {
                interpretation.InterpretationText = newInterpretationText;
            }
        }

        private void deleteInterpretation(int interpretationId)
        {
            Interpretation interpretation = interpretations?.Find(i => i.Id == interpretationId);
            if (interpretation != null)
            {
                interpretations.Remove(interpretation);
            }
        }
    }
}
