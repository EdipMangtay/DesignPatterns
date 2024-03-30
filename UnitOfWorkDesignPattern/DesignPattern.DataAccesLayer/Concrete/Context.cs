using DesignPattern.EntityLayer;
using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccesLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
           
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
