using Microsoft.AspNetCore.Mvc;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HomepageController : Controller
    {
        public IActionResult Homepage()
        {
            ViewBag.Title = "Hello MVC - commit đầu tiên!";
            return View();
        }
    }
}
