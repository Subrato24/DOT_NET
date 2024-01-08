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
                new Employee() {empId=1001, empName="Alicia K.", city="NewYork",country="USA",phone="1234567",email="Berlin@gmail.com",skillset="React js,MySql,DSA",avatar="CEO",zipcode = "12346"},
                new Employee() {empId=1002, empName="John Mark",city="Denmark",country="Poland",phone="7654328",email="London@gmail.com",skillset=".net,sql,nodejs",avatar="Manager",zipcode = "76548"},
                new Employee() {empId=1003, empName="Maria Andrus",city="Yorkshire",country="Canada",phone="0987632",email="Berlin@gmail.com",skillset="materialui,bootstrap",avatar="Frontend",zipcode = "984332"},
            };
           
        }
        public ActionResult List1()
        {
            return View(employee);
        }
    }
}