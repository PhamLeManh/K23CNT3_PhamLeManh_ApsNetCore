using Microsoft.AspNetCore.Mvc;
using PlmLesson03.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace PlmLesson03.Controllers
{
    public class PlmAccountController : Controller
    {
        public IActionResult PlmIndex()
        {
            List<PlmAccount> accounts = new List<PlmAccount>
            {
                new PlmAccount
                {
                    Id = 1,
                    Name = "Pham Thuy Duong",
                    Email = "phamthuyduong@gmail.com",
                    Phone = "0999999999",
                    Address = "Hanoi",
                    Avatar = Url.Content("~/PlmAvatar/1.jpg"),
                    Gender = 1,
                    Bio = "My Name Is Small",
                    Birthday = new DateTime(2005, 02, 23)
                }
            };
         
            return View(accounts);
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult PlmProfile(int? id)
        {
            List<PlmAccount> accounts = new List<PlmAccount>
            {
                new PlmAccount(),
            };
            var account = new PlmAccount
            {
                Id = 1,
                Name = "Pham Thuy Duong",
                Email = "phamthuyduong@gmail.com",
                Phone = "0999999999",
                Address = "Hanoi",
                Avatar = Url.Content("~/PlmAvatar/1.jpg"),
                Gender = 1,
                Bio = "My Name Is Small",
                Birthday = new DateTime(2005, 02, 23)
            };

            ViewBag.account = account;
            return View(account);
        }

    }
}