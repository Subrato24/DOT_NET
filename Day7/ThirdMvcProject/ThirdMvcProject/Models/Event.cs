using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThirdMvcProject.Models
{
    public class Event
    {
        public int eventId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(3,ErrorMessage ="Name should be more than six character")]
        public string eventName { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string description { get; set; }
        [Required(ErrorMessage = "Startdate is required")]
        public string startdate { get; set; }
        [Required(ErrorMessage = "End date is required")]
        public string enddate { get; set; }
        [Required(ErrorMessage = "Fee is required")]
        public string fees { get; set; }
        [Required(ErrorMessage = "totalseatfilled is required")]
        public string totalseatfilled { get; set; }
        [Required(ErrorMessage = "logo is required")]
        public string logo { get; set; }
        [Required(ErrorMessage = "code is required")]
        public string code { get; set; }
    }
}