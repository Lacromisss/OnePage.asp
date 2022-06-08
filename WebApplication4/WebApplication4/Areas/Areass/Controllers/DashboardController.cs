using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Areas.Areass.Controllers
{
    [Area("Areass")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
