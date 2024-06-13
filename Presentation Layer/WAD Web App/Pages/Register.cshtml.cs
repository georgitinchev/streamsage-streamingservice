using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DTOs;
using StreamSageWAD.Models;

namespace StreamSageWAD.Pages
{
    public class RegisterModel : PageModel
    {
        public IWebController webController { get; private set; }
        public string ReturnUrl { get; set; } = null;

        public RegisterModel(IWebController webController)
        {
            this.webController = webController;
        }

        [BindProperty]
        public RegisterDTO registerDTO { get; set; }

        public void OnGet(string ReturnUrl)
        {
            this.ReturnUrl = string.IsNullOrEmpty(ReturnUrl) ? "/Index" : ReturnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string ReturnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ReturnUrl = string.IsNullOrEmpty(ReturnUrl) ? Url.Content("~/Index") : ReturnUrl;

            try
            {
                var user = webController.registerUser(registerDTO.Username, registerDTO.Email, registerDTO.Password, registerDTO.FirstName, registerDTO.LastName);
                await SignInUser(user);
                return LocalRedirect(ReturnUrl ?? "/");
            }
            catch (StreamSageWAD.Exception.RegistrationFailedException)
            {
                ModelState.AddModelError(string.Empty, "Registration failed. Please try again.");
            }
            catch (System.Exception)
            {
                ModelState.AddModelError(string.Empty, "An unexpected error occurred. Please try again later.");
            }
            return Page();
        }

        private async Task SignInUser(UserDTO user)
        {
            var claims = new List<Claim>
        {
        new Claim(ClaimTypes.Name, user.Username),
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
        };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        }
    }
}
