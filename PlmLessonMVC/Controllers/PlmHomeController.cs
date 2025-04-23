using Microsoft.AspNetCore.Mvc;
using PlmLessonMVC.Models;
using System.Diagnostics;

namespace PlmLessonMVC.Controllers
{
    public class PlmHomeController : Controller
    {
        private readonly ILogger<PlmHomeController> _logger;

        public PlmHomeController(ILogger<PlmHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new PlmErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
