using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class GlucoseLevelDetailDTO
    {
        public int GlucoseLevelDetailId { get; set; }
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; }
        public double? GlucoseLevel { get; set; }
        public string PerformedBy { get; set; }
        public string Note { get; set; }
    }
}
