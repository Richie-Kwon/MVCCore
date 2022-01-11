using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;

namespace MVCCore.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Logininfo login)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                string userId = "Yera";
                string password = "123";
                if (login.UserId.Equals(userId) && login.Password.Equals(password))
                {
                    TempData["Message"] = "Successful!";
                    return RedirectToAction("Index", "Membership");
                }
                else
                {
                    message = "fail to login";
                }
            }

            else
            {
                message = "Please type down correct information";
            }

            return View(login);
        }
    }
}