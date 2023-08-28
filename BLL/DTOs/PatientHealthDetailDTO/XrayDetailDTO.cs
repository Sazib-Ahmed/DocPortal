using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class XrayDetailDTO
    {
        public int XrayDetailId { get; set; }
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; }
        public string XrayLocation { get; set; }
        public string XrayType { get; set; }
        public string XrayData { get; set; }
        public string MachineSerialNumber { get; set; }
        public string XrayTechnicianName { get; set; }
        public string ReportSummary { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
