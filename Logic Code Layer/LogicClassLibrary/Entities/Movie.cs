namespace LogicClassLibrary.Entities
{
    public class Movie : Entity
    {
        public override int Id { get; protected set; }
        public string? Title { get; private set; }
        public DateTime Year { get; private set; }
        public string? Description { get; private set; }
        public string? PosterImageURL { get; private set; }
        public string? TrailerURL { get; private set; }
        public int RuntimeMinutes { get; private set; }
        public decimal? AverageRating { get; private set; } = null;
        public List<string> Genres { get; private set; } = new List<string>();
        public override DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public Movie(int id, string title, DateTime year, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal? averageRating, List<string> genres)
        {
            Id = id;
            Title = title;
            Year = year;
            Description = description;
            PosterImageURL = posterImageURL;
            TrailerURL = trailerURL;
            RuntimeMinutes = runtimeMinutes;
            AverageRating = averageRating;
            Genres = genres;
        }
        public Movie(int id, string title, DateTime year, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal? averageRating, List<string> genres, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Year = year;
            Description = description;
            PosterImageURL = posterImageURL;
            TrailerURL = trailerURL;
            RuntimeMinutes = runtimeMinutes;
            AverageRating = averageRating;
            Genres = genres;
            CreatedAt = createdAt;
        }

        public void Update(string title, DateTime year, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal? averageRating, List<string> genres)
        {
            Title = title;
            Year = year;
            Description = description;
            PosterImageURL = posterImageURL;
            TrailerURL = trailerURL;
            RuntimeMinutes = runtimeMinutes;
            AverageRating = averageRating;
            Genres = genres;
        }
    }
}
