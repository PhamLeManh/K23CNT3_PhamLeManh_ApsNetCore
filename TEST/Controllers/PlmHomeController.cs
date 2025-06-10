using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TEST.Models;

namespace TEST.Controllers
{
    public class PlmHomeController : Controller
    {
        private readonly ILogger<PlmHomeController> _logger;

        public PlmHomeController(ILogger<PlmHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PlmIndex()
        {
            return View();
        }

        public IActionResult PlmAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
