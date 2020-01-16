using EmployeeLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDataAccess
{
    class Mapper
    {
        public static EmployeeLib.Employee Map(EmployeeDataAccess.Models.Employee employee)
        {
            return new EmployeeLib.Employee()
            {
                Id = employee.Id,
                Age=employee.Age,
                Deptid=employee.Deptid,
                Fname=employee.Fname,
                Lname=employee.Lname,
                Mname=employee.Mname,
                Salary=employee.Salary,
                Ssn=employee.Ssn,
                Startdate=employee.Startdate
            };
        }
       public static EmployeeDataAccess.Models.Employee Map(EmployeeLib.Employee employee)
        {
            return new EmployeeDataAccess.Models.Employee()
            {
                Id = employee.Id,
                Age = employee.Age,
                Deptid = employee.Deptid,
                Fname = employee.Fname,
                Lname = employee.Lname,
                Mname = employee.Mname,
                Salary = employee.Salary,
                Ssn = employee.Ssn,
                Startdate = employee.Startdate
            };
        }
    }
}
