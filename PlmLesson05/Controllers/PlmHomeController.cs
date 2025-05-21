using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlmLesson05.Models;

namespace PlmLesson05.Controllers
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
            PlmMember plmMember = new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),  
                PlmUseName = "Pham Manh",
                PlmPassword = "070220005",
                PlmFullName = "Pham Le Manh",
                PlmEmail = "phammanh@gmail.com"
            };

            return View(plmMember); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
