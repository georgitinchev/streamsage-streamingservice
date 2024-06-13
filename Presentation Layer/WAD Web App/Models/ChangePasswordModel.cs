using System.ComponentModel.DataAnnotations;
namespace StreamSageWAD.Models
{
    public class ChangePasswordModel
    {
        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}