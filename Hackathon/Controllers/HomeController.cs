using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hackathon.Models;
using Hackathon.Models.PlanParameters;
using Microsoft.EntityFrameworkCore;

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

            using (var db = new MotiveOfficeDBContext())
            {
                /*db.Users.Add(new DbUser() { Name = "111", PasswordHash = "1"});
                db.SaveChanges();*/

                /*var phonePlan = new PhonePlan("asdf", 0, 0, 2, 3, 5, 8, 9, 0, 1, 0);
                db.PhonePlans.Add(phonePlan);*/
               // db.SaveChanges();
            }
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
        public IActionResult Registration(DbUser u)
        {
            /*using (var db = new MotiveOfficeDBContext())
            {
                var user = db.Users
            }*/
            return View(null);
        }

        [HttpPost]
        public IActionResult Login(string phone, string passwordHash)
        {
            using (var db = new MotiveOfficeDBContext())
            { 
                db.Users.Load();
                var user = db.Users.First(u => u.PhoneNumber == phone && u.PasswordHash == passwordHash);//u.Name
                /*foreach (var u in db.Users)
                    if (u.PhoneNumber == phone && u.PasswordHash == passwordHash)
                    {
                        user = u;
                        break;
                    }*/
                HttpContext.Session.Set("name", Encoding.Default.GetBytes(user.Name));
                HttpContext.Session.Set("id", Encoding.Default.GetBytes(user.Id.ToString()));
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
