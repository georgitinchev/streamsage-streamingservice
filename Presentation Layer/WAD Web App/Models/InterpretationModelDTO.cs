using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
    public class InterpretationModelDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Interpretation cannot be longer than 1000 characters.")]
        public string? InterpretationText { get; set; }
    }
}
