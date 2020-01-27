using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeLib;
using EmployeeLib.Abstractions;
using EMS_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS_Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepositoryEmployee<Employee> _repository;
        public EmployeeController(IRepositoryEmployee<Employee> repository)
        {
            _repository = repository;
        }
        /*
         IActionResult
            ActionResult
                ContentResult -> Content()
                JsonResult->Json()
                ViewResult-> View()
                FileResult->File()
             */
        // GET: Employee
        public ActionResult Index()
        {
            var employees=_repository.GetEmployees();
            List<EmployeeDepartmentViewModel> evm = new List<EmployeeDepartmentViewModel>();
            foreach (var item in employees)
            {
                EmployeeDepartmentViewModel emp = new EmployeeDepartmentViewModel();
                emp.Id = item.Id;
                emp.Name=$"{item.Fname} {item.Mname} {item.Lname}";
                emp.Age = item.Age??1;
                emp.DepartmentName = item.department.Name;
                evm.Add(emp);
            }
            return View(evm);
            //return Json(new { 
            //Id=1,
            //Fname="Pushpinder",
            //Lname="Kaur"
            //});
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}