using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hackathon.Models;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            /*using (var db = new MotiveOfficeDBContext())
            {
                db.Users.Add(new DbUser() {PhoneNumber = "111", PasswordHash = "1", Name = "Noname"});
                db.SaveChanges();
            }*/
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string phone, string passwordHash)
        {
            using (var db = new MotiveOfficeDBContext())
            {
                var user = db.Users.First(u => u.PhoneNumber == phone && u.PasswordHash == passwordHash);
                HttpContext.Session.Set("name", Encoding.Default.GetBytes(user.Name));
                return View("logged", user);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
