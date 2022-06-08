using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class ExperienceController : Controller
    {
        private AppDbContext _context { get; }
        public ExperienceController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<Experience> experience = _context.experiences.ToList();
            return View(experience);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Experience ex)
        {
            if (!ModelState.IsValid) return View();

            bool ex1 = _context.experiences.Any(x => x.Title == ex.Title);
            if (ex1)
            {
                return View();

            }
            await _context.experiences.AddAsync(ex);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Experience ex1 = _context.experiences.Find(Id);
            if (ex1 == null)
            {
                return BadRequest();

            }
            _context.experiences.Remove(ex1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            Experience ex1 = _context.experiences.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(ex1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(Experience ex1, int Id)
        {
            if (ex1.Id != Id)
            {
                return BadRequest();


            }

            Experience ex2 = _context.experiences.Find(Id);
            if (ex2 == null)
            {
                return NotFound();

            }
            ex2.Title = ex1.Title;
            ex2.Subtitle = ex1.Subtitle;
            ex2.Title = ex1.Title;
            ex2.time = ex1.time;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}

