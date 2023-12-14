using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_connection.myDB
{
    internal class ApplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VU0IRUE;Initial Catalog=MuscatAirport;Integrated Security=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

