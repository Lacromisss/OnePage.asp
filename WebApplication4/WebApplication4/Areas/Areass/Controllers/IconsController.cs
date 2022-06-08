using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class IconsController : Controller
    {
        private AppDbContext _context { get; }

        public IconsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
           List<Icons> icons = _context.Icons.ToList();
            return View(icons);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Icons ico)
        {
            if (!ModelState.IsValid) return View();

            bool ico1 = _context.Icons.Any(x => x.Icoo == ico.Icoo);
            if (ico1)
            {
                return View();

            }
            await _context.Icons.AddAsync(ico);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            Icons ico1 = _context.Icons.Find(Id);
            if (ico1 == null)
            {
                return BadRequest();

            }
            _context.Icons.Remove(ico1);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            Icons ico1 = _context.Icons.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(ico1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(Icons ico1, int Id)
        {
            if (ico1.Id != Id)
            {
                return BadRequest();


            }

            Icons ico2 = _context.Icons.Find(Id);
            if (ico2 == null)
            {
                return NotFound();

            }
            ico2.Icoo = ico1.Icoo;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
