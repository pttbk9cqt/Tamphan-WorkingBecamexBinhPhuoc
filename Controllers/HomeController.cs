using Microsoft.AspNetCore.Mvc;
using Tamphan_WorkingBecamexBinhPhuoc.Models;

namespace Tamphan_WorkingBecamexBinhPhuoc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User u1 = new User()
            {
                ID = 10,
                Name = "Tam Phan",
                Password = "daylapass",
                PhoneNumber = "098776654322"
            };
            User u2 = new User()
            {
                ID = 12,
                Name = "Tam Phan 2",
                Password = "daylapass",
                PhoneNumber = "0987762"
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

