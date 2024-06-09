using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
    public class ReviewModelDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters.")]
        public string? Title { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 20, ErrorMessage = "Content must be between 20 and 1000 characters.")]
        public string? Content { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
