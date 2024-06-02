namespace DTOs
{
    public class MovieDTO
    {
        public int Id { get; private set; }
        public string? Title { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string? Description { get; private set; }
        public string? PosterImageURL { get; private set; }
        public string? TrailerURL { get; private set; }
        public int RuntimeMinutes { get; private set; }
        public decimal? AverageRating { get; private set; } = null;
        public List<string>? Genres { get; private set; }
        public List<string>? Actors { get; private set; }
        public List<string>? Directors { get; private set; }

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

        public void AddGenre(string genre)
        {
            Genres?.Add(genre);
        }

        public void AddActor(string actor)
        {
            Actors?.Add(actor);
        }

        public void AddDirector(string director)
        {
            Directors?.Add(director);
        }
    }
}