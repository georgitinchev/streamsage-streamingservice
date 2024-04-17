using EmployeesProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace EmployeesProject.Pages
{
	public class AuthenticationModel : PageModel
	{
		[BindProperty]
		public UserDTO UserDTO { get; set; }
		public void OnGet()
		{
		}
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			List<Claim> claims = new List<Claim>();

			if (UserDTO.Email.ToLower().Contains("employee"))
			{
				claims.Add(new Claim(ClaimTypes.Role, "employee"));
			}
			if (UserDTO.Email.ToLower().Contains("admin"))
			{
				claims.Add(new Claim(ClaimTypes.Role, "admin"));
			}
			else
			{
				return Page();
			}

			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

			return new RedirectToPageResult("/Index");
		}
	}
}
