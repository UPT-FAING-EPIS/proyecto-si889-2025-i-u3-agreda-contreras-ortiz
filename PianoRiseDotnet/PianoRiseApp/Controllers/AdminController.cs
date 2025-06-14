using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PianoRiseApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: /Admin/Index
        public IActionResult Index()
        {
            return View();
        }

        // Aquí puedes añadir más acciones específicas de administración
    }
}
