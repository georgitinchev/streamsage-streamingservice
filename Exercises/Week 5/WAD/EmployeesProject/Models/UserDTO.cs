using System.ComponentModel.DataAnnotations;

namespace EmployeesProject.Models
{
    public class UserDTO
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public UserDTO(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
