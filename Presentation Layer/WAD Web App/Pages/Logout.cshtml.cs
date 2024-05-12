using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    public class LogoutModel : PageModel
    {
        private WebController webController;
        public LogoutModel(WebController webController)
        {
            this.webController = webController;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await HttpContext.SignOutAsync();
            webController.logoutUser();
            return RedirectToPage("/Index");
        }
    }
}
