using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdMvcProject.Dal;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class EventController : Controller
    {
        private readonly EventDal _eventDal;
        public EventController(EventDal dal)
        {
            _eventDal = dal;
        }
        public ActionResult Index()
        {
            return View(_eventDal.GetAllEvent());
        }
        public ActionResult Details(int Id)
        {
            return View(_eventDal.GetEventById(Id));
        }
        [HttpPost]
        public ActionResult Create(Event eve)
        {
            if (ModelState.IsValid)
            {
                int result = _eventDal.InsertEvent(eve);
                if (result>0)
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