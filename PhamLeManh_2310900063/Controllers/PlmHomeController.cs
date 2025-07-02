using Microsoft.AspNetCore.Mvc;

namespace PhamLeManh_2310900063.Controllers
{
    public class PlmHomeController : Controller
    {
        public IActionResult PlmIndex()
        {
            return View();
        }

        public IActionResult PlmPrivacy()
        {
            return View();
        }
    }
}