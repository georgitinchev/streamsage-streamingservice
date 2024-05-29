using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public MovieDTO(int id, string title, DateTime releaseDate, string description, string posterImageURL, string trailerURL, int runtimeMinutes, decimal? averageRating, List<string> genres)
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
        }
	}
}
