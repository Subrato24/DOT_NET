using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdMvcProject.Models
{
    public class Employee
    {
       
        public int empId { get; set;}
        public string empName { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string skillset { get; set; }
        public string avatar { get; set; }
        public string zipcode { get; set; }
    }
}