using Microsoft.AspNetCore.Mvc;

namespace PianoRiseApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public IActionResult Index()
        {
            return View();
        }
    }
}
