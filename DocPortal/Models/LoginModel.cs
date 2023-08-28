using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static BLL.CustomValidation.CustomValidation;

namespace DocPortal.Models
{
    public class LoginModel
    {
        [Required]
        [CheckEmail]
        [StringLength(100, ErrorMessage = "Email can be maximum 100 characters long.")]
        public string Email { get; set; }
        [Required]
        [CheckPassword]
        public string Password { get; set; }
    }
}