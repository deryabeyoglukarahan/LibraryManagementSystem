using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        // Ana Sayfa
        public IActionResult Index()
        {
            return View();
        }

        // Hakkında Sayfası
        public IActionResult About()
        {
            return View();
        }
    }
}
