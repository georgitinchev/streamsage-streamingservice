using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


namespace StreamSageWAD.Pages
{

    public class AuthenticationModel : PageModel
    {
        private static readonly List<(string Username, string Password)> Users = new List<(string, string)>
    {
        ("user1", "password1"),
        ("user2", "password2")
    };

        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user != default)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, Username)
        };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                Console.WriteLine($"User {Username} authenticated successfully.");
                return RedirectToPage("/Index");
            }
            else
            {
                Console.WriteLine($"Failed to authenticate user {Username}.");
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                return Page();
            }
        }
        public async Task<IActionResult> OnPostLogout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Authentication");
        }

    }
}
