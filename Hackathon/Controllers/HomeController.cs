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
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            using (var db = new MotiveOfficeDBContext())
            {
                //db.Users.Load();
                /*var tr = new Transaction(DateTime.Now, 20, "") {UserId = 1};

                db.PhonePlans.Add(new PhonePlan("190", 0, null, 1.8, null, 1.8, 0, 1.8, null, 6, 190, 200)); 

                var dbUser = db.Users.Find(1);
                db.Transactions.Add(tr);
                dbUser.Transactions.Add(tr);
                db.SaveChanges();*/

            }
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
        public IActionResult ReplenishmentCosts()
        {
            using (var db = new MotiveOfficeDBContext())
            {
                var user = db.Users.Find(int.Parse(HttpContext.Session.GetString("id")));
                db.Transactions.Load();
                return View(user.Transactions);
            }
        }

        [HttpPost]
        public IActionResult Registration(DbUser u)
        {
            using (var db = new MotiveOfficeDBContext())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }

            return View("Index");
        }

        [HttpPost]
        public IActionResult Login(string phone, string passwordHash)
        {
            using (var db = new MotiveOfficeDBContext())
            { 
                db.Users.Load();
                DbUser user;
                try
                {
                    user = db.Users.First(u => u.PhoneNumber == phone && u.PasswordHash == passwordHash);
                }
                catch
                {
                    return View("BadLogin");
                }
                HttpContext.Session.Set("name", Encoding.Default.GetBytes(user.Name));
                HttpContext.Session.Set("id", Encoding.Default.GetBytes(user.Id.ToString()));
                return View("logged", user);
            }
        }

        public IActionResult Registration()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Exit()
        {
            HttpContext.Session.Set("name", Encoding.Default.GetBytes(""));
            HttpContext.Session.Set("id", Encoding.Default.GetBytes(""));
            return View("Index");
        }
    }
}
