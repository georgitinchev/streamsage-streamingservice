using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
	public class LoginDTO
	{
		[Required(ErrorMessage = "Username is required."), MinLength(5)]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Password is required.")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		public bool IsRememberMe { get; set; }
	}
}
