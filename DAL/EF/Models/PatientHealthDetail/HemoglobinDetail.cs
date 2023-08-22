using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class HemoglobinDetail
    {
        [Key]
        public int HemoglobinDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public DateTime RecordedAt { get; set; }  // Date and time when the test was recorded

        // Properties for Hemoglobin Test Results
        public double? HemoglobinLevel { get; set; }  // in g/dL
        public double? Hematocrit { get; set; }       // in percentage
        public double? RedBloodCellCount { get; set; }  // in million/μL
        public double? MeanCorpuscularVolume { get; set; }  // in fL
        public double? MeanCorpuscularHemoglobin { get; set; }  // in pg
        public double? MeanCorpuscularHemoglobinConcentration { get; set; }  // in g/dL
        public double? RedCellDistributionWidth { get; set; }  // in percentage


        public virtual PatientHealth PatientHealth { get; set; }
    }
}
