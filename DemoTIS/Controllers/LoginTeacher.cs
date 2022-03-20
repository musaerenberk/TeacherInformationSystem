using DemoTIS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTIS.Controllers
{
    public class LoginTeacher : Controller
    {
        private readonly ILogger<LoginTeacher> _logger;
        private readonly SchoolContext _context;

        public LoginTeacher(ILogger<LoginTeacher> logger, SchoolContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string mail, string password)
        {
            ViewData["mail"] = mail;
            ViewData["password"] = password;

            string email = "janispratt@gmail.com";
            string pass = "test";
            string email2 = "spencertaylor@gmail.com";
            string pass2 = "123";
            if (mail == email  && password == pass)
            {
                return RedirectToAction("Index", "Teachers");

            }
            else if(mail == email2 && password == pass2)
            {
                return RedirectToAction("Index", "Teacherss");
            }
            ViewBag.message = "Please, try again!";
            return View();
        }
    }
}
