using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TEST.Models;

namespace TEST.Controllers
{
    public class PlmAccountController : Controller
    {
        // Hiển thị form đăng nhập / đăng ký (gộp 2 form trong 1 View)
        [HttpGet]
        public IActionResult PlmLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Thêm chống CSRF
        public IActionResult PlmLogin(PlmUserModel user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.LoginError = "Vui lòng nhập đầy đủ thông tin.";
                return View(user);
            }

            if (user.Username == "admin" && user.Password == "123456")
            {
                HttpContext.Session.SetString("username", user.Username);
                return RedirectToAction("PlmIndex", "PlmHome");
            }

            ViewBag.LoginError = "Sai tài khoản hoặc mật khẩu.";
            return View(user);
        }


        // Đăng xuất
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("PlmLogin");
        }
    }
}
