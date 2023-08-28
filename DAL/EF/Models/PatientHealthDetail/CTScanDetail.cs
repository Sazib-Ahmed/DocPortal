using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class CTScanDetail
    {
        [Key]
        public int CTScanDetailId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }

        public string ScanLocation { get; set; }

        public string ScanData { get; set; }
        public string ScanResult { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }


        public virtual Patient Patient { get; set; }
    }
}
