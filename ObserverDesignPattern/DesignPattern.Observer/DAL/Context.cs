using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DAL
{
    public class Context :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MANGTAY\\SQLDERS;initial catalog=DesignPattern3; integrated security =true;");
        }
        public DbSet<UserProcess> UserProcesses { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }  
        public DbSet<Discount> Discounts { get; set; }
    }
}
