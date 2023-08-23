using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class OtherTestDetail
    {
        [Key]
        public int OtherTestDetailId { get; set; }


        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public string TestName { get; set; }
        public DateTime? RecordedAt { get; set; } 
        public string TestLocation { get; set; }
        public string TestType { get; set; } 
        public string TestData { get; set; } 
        public string PerformedBy { get; set; } 
        public string TestSummary { get; set; }

        public string Note { get; set; }



        // Navigation property
        public virtual PatientHealth PatientHealth { get; set; }
    }
}
