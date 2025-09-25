using apf_mhalac.Models;
using Microsoft.AspNetCore.Mvc;

namespace apf_mhalac.Controllers
{
    public class UlohyController : Controller
    {

        private static List<UserModel> Zoznam = new List<UserModel>() {
                new UserModel
                { 
                    Name = "Test1", 
                    Surname = "Novotny",
                    Email = "1@gmail.com" 
                },
                new UserModel
                {
                    Name = "Test2",
                    Surname = "Grezdo",
                    Email = "2@gmail.com"
                },
                new UserModel
                {
                    Name = "Test3",
                    Surname = "Kovacs",
                    Email = "3@gmail.com"
                },

            };
        public IActionResult Uloha1()
        {
            var userList = new List<UserInfo>();
           
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

        public IActionResult Uloha9()
        {
            return View();
        }

        public IActionResult Uloha10()
        {
            return View();
        }
        public IActionResult Uloha11()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Form(UserModel user)
        {
            Zoznam.Add(user);
            return RedirectToAction("Detail", Zoznam);
        }

        [HttpGet]
        public IActionResult Detail(UserModel user)
        {
            return View(Zoznam);
        }
    }
}
