using Microsoft.AspNetCore.Identity;

namespace Jumia.Models
{
    public class User:IdentityUser
    {
        public string? FullName { get; set; }
        public string? PNumber { get; set; }    
        public string? Gender { get; set; }
        public string? Password { get; set; }
        public string? ProfilePic { get; set; }
        public string? DOB { get; set; }
        public string? Country { get; set; }
    }
}
