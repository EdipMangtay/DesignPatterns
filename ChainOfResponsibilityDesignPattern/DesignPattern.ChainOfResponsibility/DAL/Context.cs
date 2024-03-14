using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        //Database Connection Field
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MANGTAY\\SQLDERS;initial catalog=DesignPattern1; integrated security =true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; } //Db table name = DbSet<CustomerProcess>
    }
   
}
