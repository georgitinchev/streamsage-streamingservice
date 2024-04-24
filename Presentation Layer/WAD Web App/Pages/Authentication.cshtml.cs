using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using StreamSageWAD.Models;


namespace StreamSageWAD.Pages
{
	public class AuthenticationModel : PageModel
	{
		private WebController webController = new WebController();

		public AuthenticationModel()
		{
			webController = new WebController();
		}
		public LoginDTO LoginDTO { get; private set; }

		public IActionResult OnGet()
		{
			if (Request.Cookies.ContainsKey(nameof(LoginDTO.Email)))
			{
                LoginDTO.Email = Request.Cookies[nameof(LoginDTO.Email)];
                LoginDTO.IsRememberMe = true;
            }
			return Page();
		}
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}


			// Adding cookies with Response if remember me is true bool val
			if(LoginDTO.IsRememberMe)
			{
			CookieOptions cookieOptions = new CookieOptions();
			cookieOptions.Expires = DateTime.Now.AddDays(1);
			Response.Cookies.Append(nameof(LoginDTO.Email), LoginDTO.Email, cookieOptions);
			}

			//Create session
			HttpContext.Session.SetString(nameof(LoginDTO.Email), LoginDTO.Email);

			//Add Claims
			List<Claim> claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Email, LoginDTO.Email));
			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

			return new RedirectToPageResult("/Index");
		}
	}
}
