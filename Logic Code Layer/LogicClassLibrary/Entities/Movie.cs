﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Movie : Entity
    {
        public override int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Year { get; set; }
        public string? Description { get; set; }
        public string? PosterImageURL { get; set; }
        public string? TrailerURL { get; set; }
		public int RuntimeMinutes { get; set; }
		public decimal? AverageRating { get; set; } = null;
        public List<string> Genres { get; set; } = new List<string>();
        public override DateTime CreatedAt { get; set; } = DateTime.Now;
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
	}
}
