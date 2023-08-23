using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class BloodPressureDetailDTO
    {
        public int BloodPressureDetailId { get; set; }
        public int PatientHealthId { get; set; }
        public DateTime? RecordedAt { get; set; }
        public int? SystolicPressure { get; set; }
        public int? DiastolicPressure { get; set; }
        public string PerformedBy { get; set; }
        public string Note { get; set; }
    }
}
