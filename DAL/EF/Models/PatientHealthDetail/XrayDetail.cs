using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class XrayDetail
    {
        [Key]
        public int XrayDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }
        public DateTime? RecordedAt { get; set; }

        public string XrayLocation { get; set; }
        public string XrayType { get; set; } 
        public string XrayData { get; set; } 
        public string MachineSerialNumber { get; set; } 
        public string XrayTechnicianName { get; set; } 
        public string ReportSummary { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }




        // Navigation property

        public virtual PatientHealth PatientHealth { get; set; }

    }
}
