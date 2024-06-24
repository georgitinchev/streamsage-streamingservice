using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
    public class ReviewModelDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public int Rating { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
