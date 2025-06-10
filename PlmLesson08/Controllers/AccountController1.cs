using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Account model)
    {
        if (ModelState.IsValid)
        {
            // Lưu dữ liệu vào CSDL ở đây
            return RedirectToAction("Index");
        }
        return View(model);
    }
}
