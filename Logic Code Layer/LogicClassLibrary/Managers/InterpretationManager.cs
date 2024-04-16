using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicClassLibrary.Entities;

namespace LogicClassLibrary.Managers
{
    internal class InterpretationManager
    {
        public List<Interpretation>? interpretations;

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
