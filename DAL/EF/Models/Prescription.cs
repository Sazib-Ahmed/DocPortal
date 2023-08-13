using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Prescription
    {
        [Key] // Specify the primary key
        public int PrescriptionId { get; set; }
        public DateTime PrescriptionDate { get; set; }
        [ForeignKey("Patient")] // Specify the foreign key
        public int PatientId { get; set; }
        [ForeignKey("Doctor")] // Specify the foreign key
        public int DoctorId { get; set; }
        public string ChiefComplaint { get; set; }
        public string PhysicalExam { get; set; }
        public string Investigation { get; set; }
        public string Diagnosis { get; set; }
        public DateTime NextAppointment { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }

        // Navigation property 
        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }

        public Prescription()
        {
            PrescriptionDetails = new List<PrescriptionDetail>();
        }

    }
}
