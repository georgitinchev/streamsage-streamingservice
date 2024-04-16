using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class Review : Entity
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public Review(int userId, int movieId, string content, int rating)
        {
            UserId = userId;
            MovieId = movieId;
            Content = content;
            Rating = rating;
        }
    }
}
