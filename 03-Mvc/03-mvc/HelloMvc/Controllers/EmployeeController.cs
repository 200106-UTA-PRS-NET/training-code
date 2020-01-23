using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HelloMvc.Models;
using System;

namespace HelloMvc.Controllers{
    public class EmployeeController:Controller{
       static List<Employee> employees=new List<Employee>(){
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
        [HttpGet]
        public ActionResult GetEmployee(){
            var date=Display();
            //ViewData["Employee"]=employees; // this needs type casting in View
            //ViewBag.Employee=employees; // this does not needs any type casting in Views 
            //return View();
            return View(employees);// passing Model to the view
        }
        [NonAction]// this will not be treated as an action method at all
        public string Display(){
            return DateTime.Now.ToShortDateString();
        }
// this Action is providing the UI to the USEE
        public ViewResult AddEmployee(){
            return View();
        }
        // this action is an overload of previous Action with a parameter and this is used to save the Employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee){
            
           employees.Add(employee);
           return RedirectToAction("GetEmployee");
        }
       /* [HttpGet]
        public IActionResult EditEmployee(int id){
            return View();
        }
        [HttpPost]
        public IActionResult EditEmployee(Employee employee, int? id){
            if(id != 0 || id !=null)
                employees.Add(employee);
           return RedirectToAction("GetEmployee");
        }*/
    }
}