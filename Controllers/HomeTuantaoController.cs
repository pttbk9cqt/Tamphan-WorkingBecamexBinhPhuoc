using Microsoft.AspNetCore.Mvc;
using Tamphan_WorkingBecamexBinhPhuoc.Models;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HomeTuantaoController : Controller
    {
        public IActionResult Index()
        {
            User u1 = new User()
            {
                ID = 10,
                Mucdichsudung = "Tam Phan",
                Password = "daylapass",
                Tiendien = 12354
            };
            User u2 = new User()
            {
                ID = 12,
                Mucdichsudung = "Tam Phan 2",
                Password = "daylapass",
                Tiendien = 21354684
            };
            List<User> users = new List<User>() { u1, u2 };
            ViewBag.Title = "Hello MVC - commit đầu tiên tôi tạo đó!";
            ViewBag.CC = "vl";
            //getrandom();9
            return View(users);
        }
        private string getrandom()
        {
            return "";
        }
    }
}

