using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ReviewDTO
    {
        public int Id { get; private set; }
        public int UserId { get;  private set; }
        public int MovieId { get;  private set; }
        public string? Content { get;  private set; }
        public int Rating { get; private set; }

        public ReviewDTO(int id, int userId, int movieId, string content, int rating)
        {
            Id = id;
            UserId = userId;
            MovieId = movieId;
            Content = content;
            Rating = rating;
        }
    }
}
