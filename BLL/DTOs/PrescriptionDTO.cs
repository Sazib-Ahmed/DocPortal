using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PrescriptionDTO
    {

        public int PrescriptionId { get; set; }

        public DateTime? PrescriptionDate { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public string ChiefComplaint { get; set; }

        public string PhysicalExam { get; set; }

        public string Investigation { get; set; }

        public string Diagnosis { get; set; }

        public DateTime? NextAppointment { get; set; }

    }
}
