namespace DTOs
{
    public class InterpretationDTO
    {
        public int Id { get;  set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string? InterpretationText { get; set; }
        public DateTime InterpretationDate { get;  set; }

        // constructor with datetime set to now
        public InterpretationDTO(int id, int userId, int movieId, string interpretationText)
        {
            Id = id;
            UserId = userId;
            MovieId = movieId;
            InterpretationText = interpretationText;
            InterpretationDate = DateTime.Now;
        }

        // constructor with datetime passed
        public InterpretationDTO(int id, int userId, int movieId, string interpretationText, DateTime interpretationDate)
        {
            Id = id;
            UserId = userId;
            MovieId = movieId;
            InterpretationText = interpretationText;
            InterpretationDate = interpretationDate;
        }
    }
}
