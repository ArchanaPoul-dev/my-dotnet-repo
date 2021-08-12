using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstProject_C.Models
{
    public class LoginData
    {
        [Required]
        public string Login_Ref { get; set; }
        public string Login_Password { get; set; }
    }
}