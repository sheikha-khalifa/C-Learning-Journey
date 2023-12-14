using day20_database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day20_database.MyDBContext
{
    internal class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VU0IRUE; Initial Catalog=MuscatAirport; Integrated Security=True;");
                   
        }
        //using fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)//OnModelCreating  used to made changes on classes
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employees>().Property(x=>x.Age).IsRequired().HasMaxLength(50);
               
        }
        public DbSet<Employees> employee2 { get; set; }
        public DbSet<Departments> department2 { get; set; }
        public DbSet<Projects> Project2 { get; set; }


    }

}
