using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class CholesterolLevelDetail
    {
        [Key]
        public int CholesterolLevelDetailId { get; set; }


        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public double TotalCholesterol { get; set; }

        public double LDLCholesterol { get; set; }

        public double HDLCholesterol { get; set; }

        public double Triglycerides { get; set; }

        public DateTime RecordedAt { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }




        public virtual PatientHealth PatientHealth { get; set; }
    }
}
