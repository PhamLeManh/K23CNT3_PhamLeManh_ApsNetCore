using Microsoft.AspNetCore.Mvc;
using PlmLab06.Models;

namespace PlmLab06.Controllers
{
    public class PlmEmployeeController : Controller
    {
        // Danh sách nhân viên mẫu
        private static List<PlmEmployee> plmListEmployee = new List<PlmEmployee>()
        {
            new PlmEmployee
            {
                PlmId = 1,
                PlmName = "Pham Le Manh",
                PlmBirthDay = new DateTime(2005, 2, 7),
                PlmEmail = "phamlemanh@gmail.com",
                PlmPhone = "0799079636",
                PlmSalary = 12000000,
                PlmStatus = true
            },
            new PlmEmployee
            {
                PlmId = 2,
                PlmName = "Trần Thị B",
                PlmBirthDay = new DateTime(1992, 7, 20),
                PlmEmail = "thib@gmail.com",
                PlmPhone = "0934567890",
                PlmSalary = 15000000,
                PlmStatus = false
            }
        };


        
        public IActionResult PlmIndex()
        {
            return View(plmListEmployee);
        }
        public IActionResult PlmCreate()
        {
            return View();
        }
        



        [HttpPost] 
        public IActionResult PlmCreate(PlmEmployee employee)
        {
            if (ModelState.IsValid)
            {
                employee.PlmId = plmListEmployee.Count > 0
                    ? plmListEmployee.Max(e => e.PlmId) + 1
                    : 1;

                plmListEmployee.Add(employee);
                return RedirectToAction("PlmIndex");
            }

            return View(employee);
        }
        public IActionResult PlmEdit(int id)
        {
            var employee = plmListEmployee.FirstOrDefault(e => e.PlmId == id);
            if (employee == null) return NotFound();

            return View(employee); 
        }

        
        [HttpPost]
        public IActionResult PlmEdit(PlmEmployee updatedEmployee)
        {
            if (ModelState.IsValid)
            {
                var employee = plmListEmployee.FirstOrDefault(e => e.PlmId == updatedEmployee.PlmId);
                if (employee == null) return NotFound();

                
                employee.PlmName = updatedEmployee.PlmName;
                employee.PlmBirthDay = updatedEmployee.PlmBirthDay;
                employee.PlmEmail = updatedEmployee.PlmEmail;
                employee.PlmPhone = updatedEmployee.PlmPhone;
                employee.PlmSalary = updatedEmployee.PlmSalary;
                employee.PlmStatus = updatedEmployee.PlmStatus;

                return RedirectToAction("PlmIndex");
            }

            return View(updatedEmployee);
        }


        public IActionResult PlmDelete(int id)
        {
            var emp = plmListEmployee.FirstOrDefault(e => e.PlmId == id);
            if (emp == null) return NotFound();

            plmListEmployee.Remove(emp);
            return RedirectToAction("PlmIndex");
        }
    }
}

