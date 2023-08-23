using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class CancerMarkersDetail
    {
        [Key]
        public int CancerMarkersDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public DateTime? RecordedAt { get; set; } // Date and time when the test was recorded

        public string CancerMarkersTestData { get; set; }

        // Properties related to cancer marker test results
        public string Marker1NameAndValue { get; set; }
        public string Marker2NameAndValue { get; set; }

        public string TestLocation { get; set; }

        public string TestDetails { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }

        public virtual PatientHealth PatientHealth { get; set; }
    }
}
