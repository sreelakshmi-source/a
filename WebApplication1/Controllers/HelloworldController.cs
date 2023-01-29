using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloworldController : Controller
    {

        private static List<Family> Fam = new List<Family>();

        public IActionResult Index()
        {
            return View(Fam);
        }



        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Created(Family fam)
        {
            Fam.Add(fam);
            var a = Fam.FirstOrDefault();
            return RedirectToAction(nameof(Index));
        }
    }
}
