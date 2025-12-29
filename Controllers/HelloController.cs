using Microsoft.AspNetCore.Mvc;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Homepage()
        {
            ViewBag.Tiêu_Đề = "Hello MVC - commit đầu tiên!";
            return View();
        }
    }
}