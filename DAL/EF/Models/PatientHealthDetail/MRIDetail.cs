using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class MRIDetail
    {
        [Key]
        public int MRIDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }
        public DateTime? RecordedAt { get; set; } // Date and time when the MRI was performed
        public string MRILocation { get; set; }
        public string MRIType { get; set; } // Type of MRI scan
        public string MRIData { get; set; } // Result of the MRI scan data
        public string MachineSerialNumber { get; set; } // Serial number of the MRI machine
        public string ReportSummary { get; set; } // Summary of the MRI report
        public string PerformedBy { get; set; }

        public string Note { get; set; }


        // Navigation property
        public virtual PatientHealth PatientHealth { get; set; }
    }
}
