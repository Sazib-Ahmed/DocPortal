using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class ECGDetailDTO
    {
        public int ECGDetailId { get; set; }

        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }

        public string TestLocation { get; set; }

        public string TestResult { get; set; }

        public string ECGData { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
