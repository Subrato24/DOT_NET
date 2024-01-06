using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        List<Employee> employee;
        
        public EmployeeController()
        {
            employee = new List<Employee>()
            {
                new Employee() {empId=1001, empName="Alicia K.", city="",country="",phone="",email="Berlin@gmail.com",skillset="",avatar="",zipcode = ""},
                new Employee() {empId=1002, empName="John Mark",city="",country="",phone="",email="London@gmail.com",skillset="",avatar="",zipcode = ""},
                new Employee() {empId=1003, empName="Maria Andrus",city="",country="",phone="",email="Berlin@gmail.com",skillset="",avatar="",zipcode = ""},
            };
           
        }
        public ActionResult List1()
        {
            return View(employee);
        }
    }
}