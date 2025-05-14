using Microsoft.AspNetCore.Mvc;
using PlmLesson04.Models;

namespace PlmLesson04.Controllers
{
    public class PlmBookController : Controller
    {
        // Static để lưu tạm dữ liệu trong bộ nhớ (khi không dùng DB)
        private static List<PlmBook> plmBooks = new List<PlmBook>
        {
            new PlmBook
            {
                Id = "1",
                Title = "C# Programming Basics",
                Description = "An introduction to C# programming language.",
                PlmImage = "~/Image/Book01.jpg",
                PlmPrice = "15.99",
                PlmPages = "320"
            },
            new PlmBook
            {
                Id = "2",
                Title = "ASP.NET Core Web Development",
                Description = "Learn to build modern web apps with ASP.NET Core.",
                PlmImage = "~/Image/Book02.jpg",
                PlmPrice = "24.50",
                PlmPages = "450"
            },
            new PlmBook
            {
                Id = "3",
                Title = "Mastering LINQ",
                Description = "Deep dive into LINQ for querying collections and databases.",
                PlmImage = "~/Image/Book03.jpg",
                PlmPrice = "19.95",
                PlmPages = "380"
            },
            new PlmBook
            {
                Id = "4",
                Title = "Entity Framework Core In Action",
                Description = "Learn how to work with databases using EF Core.",
                PlmImage = "~/Image/Book04.jpg",
                PlmPrice = "22.00",
                PlmPages = "410"
            },
            new PlmBook
            {
                Id = "5",
                Title = "Clean Code in C#",
                Description = "Best practices for writing clean, maintainable C# code.",
                PlmImage = "~/Image/Book05.jpg",
                PlmPrice = "27.30",
                PlmPages = "290"
            }
        };

        public IActionResult PlmIndex()
        {
            return View(plmBooks);
        }

        public IActionResult PlmCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlmCreate(PlmBook book)
        {
            if (ModelState.IsValid)
            {
                book.Id = Guid.NewGuid().ToString();
                plmBooks.Add(book);
                return RedirectToAction(nameof(PlmIndex));
            }
            return View(book);
        }

        public IActionResult PlmEdit(string id)
        {
            var book = plmBooks.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlmEdit(string id, PlmBook book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingBook = plmBooks.FirstOrDefault(b => b.Id == id);
                if (existingBook == null)
                {
                    return NotFound();
                }

                existingBook.Title = book.Title;
                existingBook.Description = book.Description;
                existingBook.PlmImage = book.PlmImage;
                existingBook.PlmPrice = book.PlmPrice;
                existingBook.PlmPages = book.PlmPages;

                return RedirectToAction(nameof(PlmIndex));
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlmDelete(string id)
        {
            var book = plmBooks.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            plmBooks.Remove(book);
            return RedirectToAction(nameof(PlmIndex));
        }
    }
}
