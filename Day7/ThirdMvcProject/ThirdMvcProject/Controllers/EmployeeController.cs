using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ThirdMvcProject.Dal;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

       private readonly EmployeeDal _employee;
        
        public EmployeeController(EmployeeDal emp)
        {
            _employee = emp;
        }
        public ActionResult List1()
        {
            return View(_employee.getAllEmployee());
        }
        public ActionResult Details(int Id) {
            return View(_employee.getEmployeeById(Id));
        }
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                int result = _employee.InsertEmployee(emp);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

    }
}