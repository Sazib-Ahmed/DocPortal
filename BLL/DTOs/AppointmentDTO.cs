using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.EF.Models.Doctor;

namespace BLL.DTOs
{
    public class AppointmentDTO
    {

        public int PId { get; set; }
        public string Name { get; set; }
        public string Deseas { get; set; }
          
        public DateTime ApoientmentDate { get; set; }
        
        public string Department { get; set; }
        public string Description { get; set; }

    }
}
