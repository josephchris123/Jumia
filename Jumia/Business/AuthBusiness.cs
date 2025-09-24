using Jumia.Data;
using Jumia.Models;
using Jumia.Services;
using Microsoft.AspNetCore.Identity;

namespace Jumia.Business
{
    public class AuthBusiness(JumiaContext _db, SignInManager<User> _signInManager)
    {
        public void Login(string password, string username)
        {
            var user = _db.User.FirstOrDefault(farmer => farmer.UserName == username);
            if (user == null)
            {

            }
            else
            {
                if (AuthService.Validate(password, user.Password))
                {
                    _signInManager.SignInAsync(user, true);
                }
            }
        }
    }
}
