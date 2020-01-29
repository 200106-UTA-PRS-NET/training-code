using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDataAccess.Models
{
    [Table("Department", Schema = "Revature")]
    public class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        // 1 to many relationships
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
