using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class CTScanDetailDTO
    {
        public int CTScanDetailId { get; set; }

        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }

        public string ScanLocation { get; set; }

        public string ScanData { get; set; }
        public string ScanResult { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
