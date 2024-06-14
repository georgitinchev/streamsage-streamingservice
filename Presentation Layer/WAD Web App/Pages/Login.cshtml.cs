using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using StreamSageWAD.Models;
using DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StreamSageWAD.Pages
{
    public class LoginModel : PageModel
    {
        public IWebController webController { get; private set; }
        public string? ReturnUrl { get; set; } = null;
        [BindNever]
        public string? Message { get; set; } = null;

        public LoginModel(IWebController webController)
        {
            this.webController = webController;
        }

        [BindProperty]
        public LoginDTO loginDTO { get; set; }

        public void OnGet(string ReturnUrl, string message = "")
        {
            ModelState.Clear();
            this.ReturnUrl = string.IsNullOrEmpty(ReturnUrl) ? "/Index" : ReturnUrl;
            this.Message = message;
        }

        public async Task<IActionResult> OnPostAsync(string ReturnUrl = null)
        {
			if (!ModelState.IsValid)
			{
				this.ReturnUrl = ReturnUrl ?? Url.Content("~/Index");
				return Page();
			}
            try
            {
                var user = webController.loginUser(loginDTO.Username, loginDTO.Password);
                await SignInUser(user, loginDTO.IsRememberMe);
                return LocalRedirect(ReturnUrl);
            }
            catch (StreamSageWAD.Exception.LoginFailedException)
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password. Please try again.");
            }
            catch (System.Exception)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred. Please try again later.");
            }
			this.ReturnUrl = ReturnUrl ?? Url.Content("~/Index");
			return Page();
		}

        private async Task SignInUser(UserDTO user, bool isPersistent)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Settings.Role)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties { IsPersistent = isPersistent };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
        }
    }
}
