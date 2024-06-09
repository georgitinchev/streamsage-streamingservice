namespace DTOs
{
    public class ReviewDTO
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int MovieId { get; private set; }
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int Rating { get; private set; }
        public DateTime ReviewDate { get; private set; }

        public ReviewDTO(int id, int userId, int movieId, string title, string content, int rating, DateTime reviewDate)
        {
            Id = id;
            UserId = userId;
            MovieId = movieId;
            Title = title;
            Content = content;
            Rating = rating;
            ReviewDate = reviewDate;
        }
        public ReviewDTO() { }
    }
}
