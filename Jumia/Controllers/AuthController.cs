using Jumia.Business;
using Microsoft.AspNetCore.Mvc;

namespace Jumia.Controllers
{
    public class AuthController(AuthBusiness authBusiness) : Controller
    {

        public IActionResult Login()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password) 
        {
            authBusiness.Login(username, password);
            return View();
         }
        public IActionResult Registration()
        {
            return View();
        }

    }
}
