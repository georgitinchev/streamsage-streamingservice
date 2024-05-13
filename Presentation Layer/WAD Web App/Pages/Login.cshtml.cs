using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamSageWAD.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace StreamSageWAD.Pages
{
    public class LoginModel : PageModel
    {
        public WebController webController { get; private set; }
        public string ReturnUrl { get; private set; }

        public LoginModel(WebController webController)
        {
            this.webController = webController;
        }

        [BindProperty]
        public LoginDTO loginDTO { get; set; }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl ?? Url.Content("~/");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                bool isAuthenticated = webController.loginUser(loginDTO.Username, loginDTO.Password);

                if (isAuthenticated)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, loginDTO.Username),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = loginDTO.IsRememberMe,
                    };
                    if (loginDTO.IsRememberMe)
                    {
                        authProperties.ExpiresUtc = DateTimeOffset.UtcNow.AddHours(24);
                    }

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return LocalRedirect(ReturnUrl ?? Url.Content("~/"));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, $"An unexpected error occurred. {e.Message}. Please try again later.");
                return Page();
            }
        }
    }
}
