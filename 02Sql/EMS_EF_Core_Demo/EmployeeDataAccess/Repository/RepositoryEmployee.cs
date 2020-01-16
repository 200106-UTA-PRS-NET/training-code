using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeDataAccess.Models;
using EmployeeLib;
using EmployeeLib.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataAccess.Repository
{
        public class RepositoryEmployee : IRepositoryEmployee<EmployeeLib.Employee>
    {
        EmployeeDbContext db;
        public RepositoryEmployee()
        {
             db = new EmployeeDbContext();
        }
        public RepositoryEmployee(EmployeeDbContext db)
        {
            this.db = db??throw new ArgumentNullException(nameof(db));
        }
        public void AddEmployee(EmployeeLib.Employee employee)
        {
            if (db.Employee.Any(e => e.Ssn == employee.Ssn) || employee.Ssn == null)
            {
                Console.WriteLine($"This employee with SSN {employee.Ssn} already exists and cannot be added");
                return;
            }
            else
                db.Employee.Add(Mapper.Map(employee));// this will generate insert query
            db.SaveChanges();// this will execute the above generate insert query
        }

        public IEnumerable<EmployeeLib.Employee> GetEmployees()
        {
            var query = from e in db.Employee
                        select Mapper.Map(e);

            return query;
        }

        public void ModifyEmployee(EmployeeLib.Employee employee)
        {
            if (db.Employee.Any(e => e.Id == employee.Id))
            {
                var emp = db.Employee.FirstOrDefault(e => e.Id == employee.Id);
                emp.Deptid = employee.Deptid;
                db.Employee.Update(emp);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Employee with this Id {employee.Id} does not exists");
                return;
            }
        }

        public void RemoveEmployee(int id)
        {
            var emp = db.Employee.FirstOrDefault(e => e.Id == id);
            if (emp.Id == id)
            {
                db.Remove(emp);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Employee with this Id {id} does not exists");
                return;
            }
        }
    }
}
