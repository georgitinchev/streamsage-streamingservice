using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Movie : Entity
    {
        public string? Title { get; set; }
        public DateTime Year { get; set; }
        public string? Description { get; set; }
        public string? PosterImageURL { get; set; }
        public string? TrailerURL { get; set; }

        public Movie(string title, DateTime year, string description, string posterImageURL, string trailerURL)
        {
            Title = title;
            Year = year;
            Description = description;
            PosterImageURL = posterImageURL;
            TrailerURL = trailerURL;
        }
    }
}
