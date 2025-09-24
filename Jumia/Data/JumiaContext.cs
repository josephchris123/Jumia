using Jumia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Jumia.Data
{
    public class JumiaContext(DbContextOptions<JumiaContext> options) : IdentityDbContext<User>(options)
    {
        public virtual DbSet<User> User { get; set; }

    }
}
    