namespace DTOs
{
    public class ReviewDTO
    {
        public int Id { get;  set; }
        public int UserId { get;  set; }
        public int MovieId { get; set; }
        public string? Title { get;  set; }
        public string? Content { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

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
