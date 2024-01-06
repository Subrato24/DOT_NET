using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdMvcProject.Models
{
    public class User
    {
        public int userId { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String rolename { get; set; }
    }
}