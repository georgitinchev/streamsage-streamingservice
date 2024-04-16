using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Interpretation : Entity
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string InterpretationText { get; set; }

        public Interpretation(int userId, int movieId, string interpretationText)
        {
            UserId = userId;
            MovieId = movieId;
            InterpretationText = interpretationText;
        }
    }
}
