using Microsoft.AspNetCore.Mvc;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello MVC - commit đầu tiên!";
            return View();
        }
    }
}
