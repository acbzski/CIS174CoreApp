using CIS174CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace CIS174CoreApp.Controllers
{
    public class HomeController : Controller
    {
        private Context context { get; set; }
        public HomeController(Context ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Student()
        {
            ViewBag.AccessLevel = 9;
            var students = context.Students.OrderBy(m => m.LastName).ToList();
            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
