using apf_mhalac.Models;
using Microsoft.AspNetCore.Mvc;

namespace apf_mhalac.Controllers
{
    public class UlohyController : Controller
    {
        public IActionResult Uloha1()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo 
                { 
                    Name = "Test1", 
                    Surname = "Novotny",
                    Email = "1@gmail.com" 
                },
                new UserInfo
                {
                    Name = "Test2",
                    Surname = "Grezdo",
                    Email = "2@gmail.com"
                },
                new UserInfo
                {
                    Name = "Test3",
                    Surname = "Kovacs",
                    Email = "3@gmail.com"
                }
            };
            return View(userList);
        }

        public IActionResult Uloha2()
        {
            return View();
        }

        public IActionResult Uloha3()
        {
            return View();
        }

        public IActionResult Uloha5()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo
                {
                    Name = "Test1",
                    Surname = "Novotny",
                    Email = "1@gmail.com"
                },
                new UserInfo
                {
                    Name = "Test2",
                    Surname = "Grezdo",
                    Email = "2@gmail.com"
                },
                new UserInfo
                {
                    Name = "Test3",
                    Surname = "Kovacs",
                    Email = "3@gmail.com"
                }
            };
            return View();
        }

        public IActionResult Uloha6()
        {
            return View();
        }

        public IActionResult Uloha7()
        {
            return View();
        }

        public IActionResult Uloha8()
        {
            return View();
        }
    }
}
