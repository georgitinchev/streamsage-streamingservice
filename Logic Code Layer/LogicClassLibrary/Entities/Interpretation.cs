using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Interpretation : Entity
    {
        public int UserId { get; private set; }
        public int MovieId { get; private set; }
        public string InterpretationText { get; private set; }

        public Interpretation(int userId, int movieId, string interpretationText)
        {
            UserId = userId;
            MovieId = movieId;
            InterpretationText = interpretationText;
        }

        public void UpdateInterpretation(string interpretationText)
        {
            InterpretationText = interpretationText;
        }
    }
}
