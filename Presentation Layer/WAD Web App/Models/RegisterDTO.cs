using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Username is required."), MinLength(5)]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required."), MinLength(5)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Repeat Password is required.")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string? RepeatPassword { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "First Name is required."), MinLength(3)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required."),  MinLength(3)]
        public string? LastName { get; set; }
    }
}
