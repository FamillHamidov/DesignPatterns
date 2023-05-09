using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.Data
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DELL;Database=Observer;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
