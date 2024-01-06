using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdMvcProject.Models;

namespace ThirdMvcProject.Controllers
{
    public class EventController : Controller
    {
        List<Event> eve;

        public EventController()
        {
            eve = new List<Event>()
            {
                new Event() {eventId=1001, eventName="singing",description="all are welcome",startdate="18-1-24",enddate="20-1-24",fees="200",totalseatfilled="78",logo="A",code = "khul js sim sim"},
                 new Event() {eventId=1002, eventName="Shree Ram mandir",description="all are welcome",startdate="24-1-24",enddate="25-1-24",fees="0",totalseatfilled="100000",logo="S",code = "jai shree ram"},
                  new Event() {eventId=1003, eventName="sports",description="all are welcome",startdate="18-4-24",enddate="20-6-24",fees="250",totalseatfilled="77",logo="S",code = "khelo india"}
            };

        }
        public ActionResult Index()
        {
            return View(eve);
        }
    }
}