using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
    public class InterpretationModelDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        [Required]
        public string InterpretationText { get; set; }

        public DateTime InterpretationDate { get; set; }
    }
}
