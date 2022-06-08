using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]

    public class EducationController : Controller
    {
        private AppDbContext _context { get; }
        public EducationController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
          List<Education> education = _context.educations.ToList();
            return View(education);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Education edu)
        {
            if (!ModelState.IsValid) return View();

            bool edu1 = _context.educations.Any(x => x.Title == edu.Title);
            if (edu1)
            {
                return View();

            }
            await _context.educations.AddAsync(edu);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Education edu1 = _context.educations.Find(Id);
            if (edu1 == null)
            {
                return BadRequest();

            }
            _context.educations.Remove(edu1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            Education edu1 = _context.educations.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(edu1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(Education edu1, int Id)
        {
            if (edu1.Id != Id)
            {
                return BadRequest();


            }

            Education edu2 = _context.educations.Find(Id);
            if (edu2 == null)
            {
                return NotFound();

            }
            edu2.Title = edu1.Title;
            edu2.Subtitle = edu1.Subtitle;
            edu2.Description = edu1.Description;
            edu2.time = edu1.time;
            edu2.Gpa=edu1.Gpa;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}

    

