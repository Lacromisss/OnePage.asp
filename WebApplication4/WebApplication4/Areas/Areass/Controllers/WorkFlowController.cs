using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class WorkFlowController : Controller
    {
        private AppDbContext _context { get; }

        public WorkFlowController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
          List<WorkFlow> work = _context.WorkFlows.ToList();
            return View(work);
        }
        public IActionResult Updatee(int? Id)
        {
            WorkFlow wf1 = _context.WorkFlows.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(wf1);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(WorkFlow wf1, int Id)
        {
            if (wf1.Id != Id)
            {
                return BadRequest();


            }

            WorkFlow wf2 = _context.WorkFlows.Find(Id);
            if (wf2 == null)
            {
                return NotFound();

            }
            wf2.Name = wf1.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WorkFlow wf)
        {
            if (!ModelState.IsValid) return View();

            bool wf1 = _context.WorkFlows.Any(x => x.Name == wf.Name);
            if (wf1)
            {
                return View();

            }
            await _context.WorkFlows.AddAsync(wf);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
