using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using ThirdMvcProject;
using ThirdMvcProject.Dal;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class SecurityController : Controller
    {
        private readonly SecurityDal _security;
        public SecurityController(SecurityDal sec) {
            _security = sec;
        }
        public ActionResult Index()
        {
            return View(_security.getAllUser());
        }
        public ActionResult Details(int Id) {
            return View(_security.getuserById(Id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(User u)
        {
            if (ModelState.IsValid)
            {
                int result = _security.addUser(u);
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
        [HttpGet ]
        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User u) {
            if (ModelState.IsValid)
            {
                User authenticatedUser = _security.Authenticate(u);
                if (authenticatedUser.email != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}