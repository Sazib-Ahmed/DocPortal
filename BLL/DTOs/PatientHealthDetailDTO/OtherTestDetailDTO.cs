using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class OtherTestDetailDTO
    {
        public int OtherTestDetailId { get; set; }
        public int PatientId { get; set; }

        public string TestName { get; set; }
        public DateTime? RecordedAt { get; set; }
        public string TestLocation { get; set; }
        public string TestType { get; set; }
        public string TestData { get; set; }
        public string PerformedBy { get; set; }
        public string TestSummary { get; set; }

        public string Note { get; set; }

    }
}
