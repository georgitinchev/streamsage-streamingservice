using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamSageWAD.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace StreamSageWAD.Pages
{
    public class RegisterModel : PageModel
    {
        private WebController webController;

        public RegisterModel(WebController webController)
        {
            this.webController = webController;
        }

        [BindProperty]
        public RegisterDTO registerDTO { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (registerDTO.Password != registerDTO.RepeatPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match.");
                return Page();
            }
            try
            {
                bool userExists = webController.loginUser(registerDTO.Email, registerDTO.Password);
                if (!userExists)
                {
                    webController.registerUser(registerDTO.Username, registerDTO.Password, registerDTO.Email, registerDTO.FirstName, registerDTO.LastName);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, registerDTO.Email),
                        new Claim(ClaimTypes.NameIdentifier, registerDTO.Username)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User already exists.");
                    return Page();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, $"An unexpected error occurred during registration. {e.Message} .Please try again later.");
                return Page();
            }
        }
    }
}
