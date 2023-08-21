using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocPortal.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}