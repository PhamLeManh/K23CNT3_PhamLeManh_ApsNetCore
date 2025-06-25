using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlmLesoon10.Models;

namespace PlmLesoon10.Controllers
{
    public class PlmCategoriesController : Controller
    {
        private readonly PlmK23cnt3Lesson10Context _context;

        public PlmCategoriesController(PlmK23cnt3Lesson10Context context)
        {
            _context = context;
        }

        // GET: /PlmCategories
        public async Task<IActionResult> PlmIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: /PlmCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /PlmCategories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PlmIndex));
            }
            return View(category);
        }

        // GET: /PlmCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();

            return View(category);
        }

        // GET: PlmCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: PlmCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (id != category.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Categories.Any(e => e.CateId == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(PlmIndex));
            }
            return View(category);
        }


        // GET: /PlmCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var category = await _context.Categories.FirstOrDefaultAsync(c => c.CateId == id);
            if (category == null) return NotFound();

            return View(category);
        }

        // POST: /PlmCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(PlmIndex));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var category = await _context.Categories.FirstOrDefaultAsync(c => c.CateId == id);
            if (category == null) return NotFound();

            return View(category);
        }
    }
}
