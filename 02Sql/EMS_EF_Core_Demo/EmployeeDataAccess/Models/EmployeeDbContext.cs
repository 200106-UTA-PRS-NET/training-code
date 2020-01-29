using System;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataAccess.Models
{
    public partial class EmployeeDbContext : DbContext //make connection to server, send data, close connection , executes query etc..... 
    {
        public EmployeeDbContext()
        {
            
        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        // Dbset types of properties denotes the tables 
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            // deleted the secret string 
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    Id=1,
                    Name="R&D",
                    Phone="765432190"
                }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id=1,
                    Fname="Pushpinder",
                    Lname="Kaur",
                    Age=32,
                    Deptid=1,
                    Salary=15000.00M,
                    Ssn="767875791",
                    Startdate=new DateTime(2019,07,03)
                });

        }

        
    }
}
