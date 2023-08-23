using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class CholesterolLevelDetailDTO
    {
        public int CholesterolLevelDetailId { get; set; }
        public int PatientHealthId { get; set; }

        public double TotalCholesterol { get; set; }

        public double LDLCholesterol { get; set; }

        public double HDLCholesterol { get; set; }

        public double Triglycerides { get; set; }

        public DateTime RecordedAt { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }

    }
}
