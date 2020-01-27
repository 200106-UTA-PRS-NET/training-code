using EmployeeLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDataAccess
{
    class Mapper
    {
        public static EmployeeLib.Employee Map(EMS_Data.Models.Employee employee)
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
       public static EMS_Data.Models.Employee Map(EmployeeLib.Employee employee)
        {
            return new EMS_Data.Models.Employee()
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
