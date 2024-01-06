using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdMvcProject.Models
{
    public class Event
    {
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string description { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string fees { get; set; }
        public string totalseatfilled { get; set; }
        public string logo { get; set; }
        public string code { get; set; }
    }
}