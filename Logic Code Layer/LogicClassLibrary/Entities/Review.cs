namespace LogicClassLibrary.Entities
{
    public class Review : Entity
    {
        public int UserId { get; private set; }
        public int MovieId { get; private set; }
        public string Content { get; private set; }
        public int Rating { get; private set; }

        public Review(int userId, int movieId, string content, int rating)
        {
            UserId = userId;
            MovieId = movieId;
            Content = content;
            Rating = rating;
        }

        public void Update(string content, int rating)
        {
            Content = content;
            Rating = rating;
        }
    }
}
