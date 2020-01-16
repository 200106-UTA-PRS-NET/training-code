using EmployeeDataAccess.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp
{
    class Program
    {
        static Employee employee1() {
            return new Employee() { 
            Fname="Pushpinder",
            Lname="Kaur",
            Salary=16000.00M,
            Age=28,
            Ssn="1213AS545",
            Startdate=new DateTime(2017,09,09),
            Deptid=1
            };
        }

        static void Main(string[] args)
        {
            // Configuration to access User Secrets.json
            var repo=Dependencies.CreateEmployeeRepository();
            var employees= repo.GetEmployees();
            

        /*
            AddEmployee(db,employee1());
            Console.WriteLine("--------------Employee Added------------------");
            Employee emp2 = new Employee() {Id=1, Deptid = 2};
            //ModifyEmployee(db,emp2);
            // Console.WriteLine("-----------Employee Modified----------");
           // RemoveEmployee(db,3);
            var employees = GetEmployees(db);            
            */
            foreach (var emp in employees)
            {
                if (emp.Mname !="" || emp.Mname != null)
                     Console.WriteLine($"{emp.Fname} {emp.Mname} {emp.Lname}");
                else
                    Console.WriteLine($"{emp.Fname} {emp.Lname}");
            }
        }
        /*
        static IEnumerable<Employee> GetEmployees(EmployeeDbContext db)
        {
            var query= from e in db.Employee
                       select e;

            return query;
        }

        static void AddEmployee(EmployeeDbContext db,Employee employee)
        {
            if (db.Employee.Any(e => e.Ssn == employee.Ssn) || employee.Ssn == null)
            {
                Console.WriteLine($"This employee with SSN {employee.Ssn} already exists and cannot be added");
                return;
            }
            else
                db.Employee.Add(employee);// this will generate insert query
                db.SaveChanges();// this will execute the above generate insert query
        }

        static void ModifyEmployee(EmployeeDbContext db,Employee employee)
        {
            if (db.Employee.Any(e=>e.Id == employee.Id))
            {
                var emp= db.Employee.FirstOrDefault(e => e.Id == employee.Id);
                emp.Deptid = employee.Deptid;
                db.Employee.Update(emp);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Employee with this Id {employee.Id} does not exists");
            }
           
        }
        static void RemoveEmployee(EmployeeDbContext db,int id)
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
        */
    }
}
