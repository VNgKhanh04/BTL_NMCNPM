using Microsoft.EntityFrameworkCore;
using BTL_NMCNPM.Models;

namespace BTL_NMCNPM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
