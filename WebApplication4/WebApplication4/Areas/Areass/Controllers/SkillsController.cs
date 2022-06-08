using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class SkillsController : Controller
    {
        private AppDbContext _context { get; }
        public SkillsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
         List<Skill> skill = _context.skills.ToList();

            return View(skill);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skill sk)
        {
            if (!ModelState.IsValid) return View();

            bool sk1 = _context.skills.Any(x => x.Title == sk.Title);
            if (sk1)
            {
                return View();

            }
            await _context.skills.AddAsync(sk);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Skill sk1 = _context.skills.Find(Id);
            if (sk1 == null)
            {
                return BadRequest();

            }
            _context.skills.Remove(sk1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            Skill sk1 = _context.skills.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(sk1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(Skill sk1, int Id)
        {
            if (sk1.Id != Id)
            {
                return BadRequest();


            }

            Skill sk2 = _context.skills.Find(Id);
            if (sk2 == null)
            {
                return NotFound();

            }
            sk2.Title = sk1.Title;
            sk2.Name = sk1.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}
