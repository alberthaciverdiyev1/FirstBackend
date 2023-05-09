using Microsoft.AspNetCore.Mvc;

namespace FirstBackendTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
    }
}
