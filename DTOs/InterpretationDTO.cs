using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class InterpretationDTO
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int MovieId { get; private set; }
        public string? InterpretationText { get; private set; }

        public InterpretationDTO(int id, int userId, int movieId, string interpretationText)
        {
            Id = id;
            UserId = userId;
            MovieId = movieId;
            InterpretationText = interpretationText;
        }
    }
}
