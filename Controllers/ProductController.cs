using Microsoft.AspNetCore.Mvc;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {   ViewData["Title"] = "Product List - Welcome to our store!";
            return View();
        }
    }
}
