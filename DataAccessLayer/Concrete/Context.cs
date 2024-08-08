using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KR485FT\\SQLEXPRESS; initial catalog=DbUow; integrated security=true");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
