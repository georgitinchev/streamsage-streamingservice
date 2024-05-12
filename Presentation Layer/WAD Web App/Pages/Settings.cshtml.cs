using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamSageWAD.Pages
{
    [Authorize]
    public class SettingsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
