using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Appointment
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public string Deseas { get; set; }


        public DateTime ApoientmentDate { get; set; }


        public string Department { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }

        public int DoctorId { get; set; }
    }
}

