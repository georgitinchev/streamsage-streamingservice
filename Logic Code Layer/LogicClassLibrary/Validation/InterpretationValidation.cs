using DTOs;
using System;

namespace LogicClassLibrary.Validation
{
    public static class InterpretationValidation
    {
        public static bool IsValidInterpretation(InterpretationDTO interpretation)
        {
            if (interpretation == null)
                throw new ArgumentNullException(nameof(interpretation), "Interpretation cannot be null.");

            if (interpretation.UserId <= 0)
                throw new ArgumentException("User ID must be greater than zero.");

            if (interpretation.MovieId <= 0)
                throw new ArgumentException("Movie ID must be greater than zero.");

            if (string.IsNullOrWhiteSpace(interpretation.InterpretationText))
                throw new ArgumentException("Interpretation text cannot be empty or whitespace.");

            if (interpretation.InterpretationText.Length > 1000) 
                throw new ArgumentException("Interpretation text cannot exceed 1000 characters.");

            return true;
        }
    }
}
