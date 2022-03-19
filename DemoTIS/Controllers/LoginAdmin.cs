using DemoTIS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DemoTIS.Controllers
{
    public class LoginAdmin : Controller
    {
        private readonly ILogger<LoginAdmin> _logger;
        private readonly SchoolContext _context;

        public LoginAdmin(ILogger<LoginAdmin> logger, SchoolContext context)
        {
            _context = context;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Index(string mail, string password)
        {
            ViewData["mail"] = mail;
            ViewData["password"] = password;
            string email = "humanr@gmail.com";
            string pass = "123";
            if (mail == email && password == pass)
            {
                return RedirectToAction("Index","Admin");

            }
            ViewBag.message = "Please, try again!";
            return View();
        }
    }
}
