using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class CancerMarkersDetailDTO
    {
        public int CancerMarkersDetailId { get; set; }
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; } 

        public string CancerMarkersTestData { get; set; }
        public string Marker1NameAndValue { get; set; }
        public string Marker2NameAndValue { get; set; }

        public string TestLocation { get; set; }

        public string TestDetails { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
