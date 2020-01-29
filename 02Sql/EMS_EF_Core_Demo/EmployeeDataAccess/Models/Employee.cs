using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDataAccess.Models
{
    [Table("Employee",Schema ="Revature")]
    public class Employee
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public DateTime? Startdate { get; set; }
        public decimal? Salary { get; set; }
        [RegularExpression("[0-9]{9}",ErrorMessage ="Invalid SSN, it should be 9 digits SSN")]
        public string Ssn { get; set; }
        public int? Deptid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        
        [NotMapped]
        public string FullName { get {
                if (Mname != null)
                    return $"{Fname} {Mname} {Lname}";
                else
                    return $"{Fname} {Lname}";
            } 
        }


        // 1 to 1 relationship
        public virtual Department Dept { get; set; }
    }
}
