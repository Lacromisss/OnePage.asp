using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class InterestController : Controller
    {
          private AppDbContext _context;
            
        public InterestController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<Interest> interests = _context.interests.ToList();
            return View(interests);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Interest intt)
        {
            if (!ModelState.IsValid) return View();

            bool in1 = _context.interests.Any(x => x.Description == intt.Description);
            if (in1)
            {
                return View();

            }
            await _context.interests.AddAsync(intt);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Interest in1 = _context.interests.Find(Id);
            if (in1 == null)
            {
                return BadRequest();

            }
            _context.interests.Remove(in1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            Interest aw1 = _context.interests.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(aw1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(Interest in1, int Id)
        {
            if (in1.Id != Id)
            {
                return BadRequest();


            }

            Interest in2 = _context.interests.Find(Id);
            if (in2 == null)
            {
                return NotFound();

            }
            in2.Description = in1.Description;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
