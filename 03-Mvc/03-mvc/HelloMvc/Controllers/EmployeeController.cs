using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HelloMvc.Models;
namespace HelloMvc.Controllers{
    public class EmployeeController:Controller{
        List<Employee> employees=new List<Employee>(){
            new Employee(){
                Id=1,
                FirstName="Fred",
                LastName="Belotte"
            },
            new Employee(){
                Id=2,
                FirstName="Cameron",
                LastName="Coley"
            }
        };
        public ActionResult GetEmployee(){
            return View(employees);
        }
    }
}