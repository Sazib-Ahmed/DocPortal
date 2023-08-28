using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.EF.Models.Doctor;
using static BLL.CustomValidation.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
    public class DoctorDTO
    {
        public int DoctorId { get; set; }
        //[Required]
        //[CheckName]
        //[StringLength(50, ErrorMessage = "Name can be maximum 50 characters long.")]
        public string Name { get; set; }
        //[StringLength(100)]
        public string Speciality { get; set; }
        public string Image { get; set; }
        //[Required]
        public string Phone { get; set; }
        //[Required]
        //[CheckPassword]
        public string Password { get; set; }
        //[Required]
        //[CheckEmail]
        //[StringLength(100, ErrorMessage = "Email can be maximum 100 characters long.")]
        public string Email { get; set; }
        //[StringLength(100, ErrorMessage = "Address can be maximum 100 characters long.")]
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //[Required]
        //[StringLength(20)]
        public string Sex { get; set; }
        //[StringLength(100)]
        //[Required]
        public string Education { get; set; }
        //[StringLength(100)]
        //[Required]
        public string ExperienceYears { get; set; }
        //[StringLength(100)]
        //[Required]
        public string RegistrationNumber { get; set; }
        //[StringLength(100)]
        //[Required]
        public string Certifications { get; set; }
        //[StringLength(100)]
        public string Description { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public DateTime? LockoutEnd { get; set; }
    }
}
