using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADS.Blazor.Assessment.Server.Views.Home
{
    public class IndexModel : PageModel
    {
        public IActionResult OnPost()
        {
            return RedirectToPage("/Products");
        }
    }
}
