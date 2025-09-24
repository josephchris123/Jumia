using Jumia.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using bCrypt = BCrypt.Net.BCrypt;

namespace Jumia.Services
{
    public class AuthService(UserManager<User> _userManager)
    {

        public static string Encrypt(string plainPassword)
        {
            var salt = bCrypt.GenerateSalt();
            var hashedPassword = bCrypt.HashPassword(plainPassword, salt);
            return hashedPassword;
        }
        public static bool Validate(string plainPassword, string encryptedPassword)
        {
            return bCrypt.Verify(plainPassword, encryptedPassword);
        }


        public async Task AddUserRole(User usr)
        {
            if (usr != null)
            {
                await _userManager.AddClaimAsync(usr, new Claim("Role", "User"));
                await _userManager.AddToRoleAsync(usr, "User");
            }
        }


        public Task AddStaffRoleAsync(User usr)
        {
            throw new NotImplementedException();
        }
    }
}
