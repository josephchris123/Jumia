using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jumia.Controllers
{
    public class UserController : Controller
    {


        public IActionResult Dashboard()
        {
            return View();
        }
          public IActionResult Display()
        {
            return View();
        }   
        public IActionResult LogOut()
        {
            return View();
        }    
        public IActionResult Profile()
        {
            return View();
        }

    }
}
