using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhamLeManh_2310900063.Data;
using PhamLeManh_2310900063.Models;

namespace PhamLeManh_2310900063.Controllers
{
    public class PlmEmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public PlmEmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PlmEmployee/PlmIndex
        public async Task<IActionResult> PlmIndex()
        {
            return View(await _context.PlmEmployees.ToListAsync());
        }

        // GET: PlmEmployee/PlmDetails/5
        public async Task<IActionResult> PlmDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plmEmployee = await _context.PlmEmployees
                .FirstOrDefaultAsync(m => m.PlmEmpId == id);
            if (plmEmployee == null)
            {
                return NotFound();
            }

            return View(plmEmployee);
        }

        // GET: PlmEmployee/PlmCreate
        public IActionResult PlmCreate()
        {
            return View();
        }

        // POST: PlmEmployee/PlmCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlmCreate([Bind("PlmEmpId,PlmEmpName,PlmEmpLevel,PlmEmpStartDate,PlmEmpStatus")] PlmEmployee plmEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plmEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PlmIndex));
            }
            return View(plmEmployee);
        }

        // GET: PlmEmployee/PlmEdit/5
        public async Task<IActionResult> PlmEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plmEmployee = await _context.PlmEmployees.FindAsync(id);
            if (plmEmployee == null)
            {
                return NotFound();
            }
            return View(plmEmployee);
        }

        // POST: PlmEmployee/PlmEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlmEdit(int id, [Bind("PlmEmpId,PlmEmpName,PlmEmpLevel,PlmEmpStartDate,PlmEmpStatus")] PlmEmployee plmEmployee)
        {
            if (id != plmEmployee.PlmEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plmEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlmEmployeeExists(plmEmployee.PlmEmpId))
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
            return View(plmEmployee);
        }

        // GET: PlmEmployee/PlmDelete/5
        public async Task<IActionResult> PlmDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plmEmployee = await _context.PlmEmployees
                .FirstOrDefaultAsync(m => m.PlmEmpId == id);
            if (plmEmployee == null)
            {
                return NotFound();
            }

            return View(plmEmployee);
        }

        // POST: PlmEmployee/PlmDelete/5
        [HttpPost, ActionName("PlmDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PlmDeleteConfirmed(int id)
        {
            var plmEmployee = await _context.PlmEmployees.FindAsync(id);
            _context.PlmEmployees.Remove(plmEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PlmIndex));
        }

        private bool PlmEmployeeExists(int id)
        {
            return _context.PlmEmployees.Any(e => e.PlmEmpId == id);
        }
    }
}