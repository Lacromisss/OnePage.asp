using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Dal;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;


        }
        public async Task<IActionResult> Index()
        {
            Vm vm = new Vm
            {
                users = await _context.Users.ToListAsync(),
                socialMedia = await _context.SocialMedias.ToListAsync(),
                experiences= await _context.experiences.ToListAsync(),
                educations= await _context.educations.ToListAsync(),
                skills= await _context.skills.ToListAsync(),
                icons= await _context.Icons.ToListAsync(),
                workFlows= await _context.WorkFlows.ToListAsync(),
                awards=await _context.awards.ToListAsync(),
                interests = await _context.interests.ToListAsync()




            };
            return View(vm);
        }


    }




}
