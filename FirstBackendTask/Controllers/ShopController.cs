using Microsoft.AspNetCore.Mvc;

namespace FirstBackendTask.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }
        public IActionResult Card() {
            return View();

        }
    }
}
