using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class AwardController : Controller
    {

        private AppDbContext _context { get; }
        public AwardController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
          List<Award> award = _context.awards.ToList();

            

            return View(award);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Award aw)
        {
            if (!ModelState.IsValid) return View();

            bool aw1 = _context.awards.Any(x => x.Description1 == aw.Description1);
            if (aw1)
            {
                return View();

            }
            await _context.awards.AddAsync(aw);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Award aw1 = _context.awards.Find(Id);
            if (aw1 == null)
            {
                return BadRequest();

            }
            _context.awards.Remove(aw1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public  IActionResult Updatee(int? Id)
        {
            Award aw1 = _context.awards.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(aw1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Updatee(Award aw1, int Id)
        {
            if (aw1.Id != Id)
            {
                return BadRequest();


            }

            Award aw2 = _context.awards.Find(Id);
            if (aw2 == null)
            {
                return NotFound();

            }
            aw2.Description1 = aw1.Description1;
            aw2.Description2 = aw1.Description2;

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
