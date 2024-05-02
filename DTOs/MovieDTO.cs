﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public decimal? AverageRating { get; set; } = null;
		public List<string>? Genres { get; set; }
	}
}
