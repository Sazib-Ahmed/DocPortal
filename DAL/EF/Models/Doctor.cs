using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.EF.Models
{
    public class Doctor
    {
        [Key] // Specify the primary key
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DGender? Sex { get; set; }
        public string Education { get; set; }
        public string ExperienceYears { get; set; }
        public string RegistrationNumber { get; set; }
        public string Certifications { get; set; }
        public string Description { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public DateTime? LockoutEnd { get; set; }

        // Navigation property
        public virtual ICollection<Prescription> Prescriptions { get; set; }

        public Doctor()
        {
            Prescriptions = new List<Prescription>();
        }

        public enum DGender
        {
            Male,
            Female,
            Other
        }

    }
}
