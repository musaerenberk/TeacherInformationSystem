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
    public class Teachers : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext _context;

        public Teachers(ILogger<HomeController> logger, SchoolContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = _context.Teachers.ToList();
            return View(list);
        }
        public async Task<IActionResult> Delete(int Id)
        {
            var teacher = await _context.Teachers.FindAsync(Id);
            _context.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (teacher.Id == 0)
            {
                await _context.AddAsync(teacher);
            }
            else
            {
                _context.Update(teacher);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Teacher(int? Id)
        {
            Teacher teacher;
            if (Id.HasValue)
            {
                teacher = _context.Teachers.Find(Id);

            }
            else
            {
                teacher = new Teacher();
            }
            return View(teacher);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
