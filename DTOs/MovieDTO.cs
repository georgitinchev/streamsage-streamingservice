namespace DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Description { get; set; }
        public string? PosterImageURL { get; set; }
        public string? TrailerURL { get; set; }
        public int RuntimeMinutes { get; set; }
        public decimal? AverageRating { get; set; }
        public List<string>? Genres { get; set; }
        public List<string>? Actors { get; set; }
        public List<string>? Directors { get; set; }

        public MovieDTO(int id, string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal? averageRating, List<string> genres, List<string> actors, List<string> directors)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            Description = description;
            PosterImageURL = posterImageURL;
            TrailerURL = trailerURL;
            RuntimeMinutes = runtimeMinutes;
            AverageRating = averageRating;
            Genres = genres;
            Actors = actors;
            Directors = directors;
        }
    }
}
