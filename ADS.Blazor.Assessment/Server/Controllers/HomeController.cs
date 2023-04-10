using Microsoft.AspNetCore.Mvc;

namespace ADS.Blazor.Assessment.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
