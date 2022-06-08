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


    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<User> user = _context.Users.ToList();
            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (!ModelState.IsValid) return View();

            bool user1 = _context.Users.Any(x => x.Name == user.Name);
            if (user1)
            {
                return View();

            }
            await _context.Users.AddAsync(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Delete(int Id)
        {
            User users = _context.Users.Find(Id);
            if (users == null)
            {
                return BadRequest();

            }
            _context.Users.Remove(users);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Updatee(int? Id)
        {
            User user = _context.Users.Find(Id);
            if (Id == null)
            {
                return BadRequest();

            }
            return View(user);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Updatee(User user, int Id)
        {
            if (user.Id != Id)
            {
                return BadRequest();


            }

            User user1 = _context.Users.Find(Id);
            if (user1 == null)
            {
                return NotFound();

            }
            user1.Name = user.Name;
            user1.Description = user.Description;
            user1.Adress = user.Adress;
            user1.SocialMedias = user.SocialMedias;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }

}

