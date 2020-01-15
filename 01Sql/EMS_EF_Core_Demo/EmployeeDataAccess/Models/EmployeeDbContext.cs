using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "Revature");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee", "Revature");

                entity.HasIndex(e => e.Ssn)
                    .HasName("UQ__Employee__DDDF0AE6EE7D75C9")
                    .IsUnique();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Deptid)
                    .HasColumnName("deptid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((5000))");

                entity.Property(e => e.Ssn)
                    .HasColumnName("ssn")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Dept_Employee_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
