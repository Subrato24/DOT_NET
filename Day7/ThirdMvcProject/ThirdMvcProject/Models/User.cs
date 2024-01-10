using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThirdMvcProject.Models
{
    public class User
    {
        public int userId { get; set; }
        [Required(ErrorMessage ="Email required")]
        public String email { get; set; }
        [Required(ErrorMessage = "Password required")]
        public String password { get; set; }
        public String rolename { get; set; }
    }
}