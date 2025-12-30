using Microsoft.AspNetCore.Mvc;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Hello MVC - commit đầu tiên!";
            return View();
        }
    }
}
