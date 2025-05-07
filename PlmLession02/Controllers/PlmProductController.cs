using Microsoft.AspNetCore.Mvc;

namespace PlmLession02.Controllers
{
    public class PlmProductController : Controller
    {
        public IActionResult PlmIndex()
        {
            ViewData["messageData"] = "Du lieu tu view data";
            ViewBag.messageData = "Du lieu tu view bag";
            TempData["messageData"] = "Du lieu tu temp data";

            return View();
        }
    }
}
