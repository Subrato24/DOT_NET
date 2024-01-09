using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThirdMvcProject.Models
{
    public class Employee
    {
       
        public int empId { get; set;}
        [Required(ErrorMessage ="Name of employee is must")]
        [MinLength(3,ErrorMessage ="Employee should be more than 3 character")]
        public string empName { get; set; }
        [Required(ErrorMessage = "Name of city is must")]
        public string city { get; set; }
        [Required(ErrorMessage = "Name of country is must")]
        public string country { get; set; }
        [Required(ErrorMessage = "employee phone number is must")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Email of employee is must")]
        public string email { get; set; }
        [Required(ErrorMessage = "min 2 skillset of employee is must")]
        public string skillset { get; set; }

        public string avatar { get; set; }
        [Required(ErrorMessage = "Zipcode is must")]
        public string zipcode { get; set; }
    }
}