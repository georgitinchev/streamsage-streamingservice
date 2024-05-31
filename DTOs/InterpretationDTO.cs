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
