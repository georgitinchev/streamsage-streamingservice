namespace LogicClassLibrary.Entities
{
    public class Review : Entity
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int MovieId { get; private set; }
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int Rating { get; private set; }
        public DateTime ReviewDate { get; private set; }

        // Review constructor with date time set to now
        public Review(int reviewId, int userId, int movieId, string title, string content, int rating)
        {
            Id = reviewId;
            UserId = userId;
            MovieId = movieId;
            Title = title;
            Content = content;
            Rating = rating;
            ReviewDate = DateTime.Now;
        }

        // constructor with specific datetime
        public Review(int reviewId, int userId, int movieId, string title, string content, int rating, DateTime reviewDate)
        {
            Id = reviewId;
            UserId = userId;
            MovieId = movieId;
            Title = title;
            Content = content;
            Rating = rating;
            ReviewDate = reviewDate;
        }

        public void Update(string title, string content, int rating)
        {
            Title = title;
            Content = content;
            Rating = rating;
            ReviewDate = DateTime.Now; 
        }
    }
}
