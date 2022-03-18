using DemoTIS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTIS.Controllers
{
    public class Student : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext _context;

        public Student(ILogger<HomeController> logger, SchoolContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = _context.Teachers.ToList();
            return View(list);
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
