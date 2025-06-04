using Microsoft.AspNetCore.Mvc;
using PlmLesson07.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlmLesson07.Controllers
{
    public class PlmEmployeeController : Controller
    {
        private static List<PlmEmployee> _employees = GetSampleEmployees();

        // Mock data:
        public static List<PlmEmployee> GetSampleEmployees()
        {
            return new List<PlmEmployee>
            {
                new PlmEmployee {
                    PlmId = 1,
                    PlmName = "Pham Le Manh",
                    PlmBirthDay = new DateTime(2005, 2, 7),
                    PlmEmail = "phamlemanh@example.com",
                    PlmPhone = "0799079636",
                    PlmSalary = 15000000,
                    PlmStatus = true
                },
                new PlmEmployee {
                    PlmId = 2,
                    PlmName = "Nguyen Van B",
                    PlmBirthDay = new DateTime(1990, 1, 1),
                    PlmEmail = "b@example.com",
                    PlmPhone = "0123456789",
                    PlmSalary = 13000000,
                    PlmStatus = false
                }
            };
        }

        // GET: /PlmEmployee/PlmIndex
        public IActionResult PlmIndex()
        {
            return View(_employees);
        }

        // GET: /PlmEmployee/PlmCreate
        public IActionResult PlmCreate()
        {
            return View();
        }

        // POST: /PlmEmployee/PlmCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlmCreate(PlmEmployee employee)
        {
            if (ModelState.IsValid)
            {
                
                _employees.Add(employee);
                return RedirectToAction(nameof(PlmIndex));
            }
            return View(employee);
        }
        // 
        [HttpGet]
        public IActionResult PlmEdit(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.PlmId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PlmEdit(int id, PlmEmployee updated)
        {
            var emp = _employees.FirstOrDefault(e => e.PlmId == id);
            if (emp == null) return NotFound();

            if (ModelState.IsValid)
            {
                emp.PlmName = updated.PlmName;
                emp.PlmBirthDay = updated.PlmBirthDay;
                emp.PlmEmail = updated.PlmEmail;
                emp.PlmPhone = updated.PlmPhone;
                emp.PlmSalary = updated.PlmSalary;
                emp.PlmStatus = updated.PlmStatus;

                return RedirectToAction(nameof(PlmIndex));
            }
            return View(updated);
        }

        // 
        [HttpGet]
        public IActionResult PlmDelete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.PlmId == id);
            if (emp == null) return NotFound();
            return View(emp);
        }

        [HttpPost, ActionName("PlmDelete")]
        [ValidateAntiForgeryToken]
        public IActionResult PlmDeleteConfirmed(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.PlmId == id);
            if (emp != null)
            {
                _employees.Remove(emp);
            }
            return RedirectToAction(nameof(PlmIndex));
        }

    }
}