using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StreamSageWAD.Models
{
	public class UserDetailsModel
	{
		[BindProperty, Required, MinLength(3)]
		public string? Username { get; set; }

		[BindProperty, Required, EmailAddress]
		public string? Email { get; set; }

		[BindProperty, Required]
		public string? FirstName { get; set; }

		[BindProperty, Required]
		public string? LastName { get; set; }
	}
}
