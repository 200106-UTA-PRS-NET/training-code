using System;
using System.Collections.Generic;

namespace EmployeeDataAccess.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public DateTime? Startdate { get; set; }
        public decimal? Salary { get; set; }
        public string Ssn { get; set; }
        public int? Deptid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }

        public virtual Department Dept { get; set; }
    }
}
