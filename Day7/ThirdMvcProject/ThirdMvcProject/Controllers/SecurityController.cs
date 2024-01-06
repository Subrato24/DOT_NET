using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdMvcProject;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class SecurityController : Controller
    {
        List<User> security;
        public SecurityController() { 
            security = new List<User>()
            {
                new User() {userId=101, email="abc@123.gmail", password="12345", rolename="security"},
                new User() {userId=102, email="mno@345.gmail", password="76876", rolename = "organizer"},
                new User() {userId=103, email="pqr@678.gmail", password="98989", rolename = "catering"}
            };    
        }
        public ActionResult Index()
        {
            return View(security);
        }
    }
}