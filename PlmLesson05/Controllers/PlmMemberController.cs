using Microsoft.AspNetCore.Mvc;
using PlmLesson05.DataModels;

namespace PlmLesson05.Controllers
{
    public class PlmMemberController : Controller
    {
        private static List<PlmMember> plmListMember = new List<PlmMember>()
        {
            new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),
                PlmUseName = "Pham Manh",
                PlmPassword = "07022005",
                PlmFullName = "Pham Le Manh",
                PlmEmail = "phammanh@gmail.com"
            },
            new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),
                PlmUseName = "user02",
                PlmPassword = "pass02",
                PlmFullName = "Tran Thi B",
                PlmEmail = "b@gmail.com"
            },
            new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),
                PlmUseName = "user03",
                PlmPassword = "pass03",
                PlmFullName = "Le Van C",
                PlmEmail = "c@gmail.com"
            },
            new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),
                PlmUseName = "user04",
                PlmPassword = "pass04",
                PlmFullName = "Pham Thi D",
                PlmEmail = "d@gmail.com"
            },
            new PlmMember
            {
                PlmMemberId = Guid.NewGuid().ToString(),
                PlmUseName = "user05",
                PlmPassword = "pass05",
                PlmFullName = "Hoang Van E",
                PlmEmail = "e@gmail.com"
            }
        };

        public IActionResult PlmIndex()
        {
            return View(plmListMember); 
        }
    }
}
