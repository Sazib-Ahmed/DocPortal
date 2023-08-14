using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Patient
    {
        [Key] // Specify the primary key

        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PGender Sex { get; set; }
        public string Description { get; set; }

        //Navigation property
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

        public Patient()
        {
            Prescriptions = new List<Prescription>();
            Appointments = new List<Appointment>();
        }


        public enum PGender
        {
            Male,
            Female,
            Other
        }

    }
}
