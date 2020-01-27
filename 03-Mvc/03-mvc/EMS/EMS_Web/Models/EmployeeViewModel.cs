using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_Web.Models
{
    public class EmployeeViewModel
    {
        [Display(Name ="First Name")]
        public string Fname { get; set; }
        [Display(Name = "Last Name")]
        public string Lname { get; set; }

        [Display(Name = "Middle Name")]
        public string Mname { get; set; }
        [Range(minimum:16,maximum:70)]
        public int Age { get; set; }
        public decimal Salary { get; set; }
        [Display(Name ="Social Security Number"),RegularExpression("[0-9]{9}")]
        public string Ssn { get; set; }
        [Display(Name ="Date of Joining")]
        public DateTime StartDate { get; set; } = DateTime.Now;


    }
}
