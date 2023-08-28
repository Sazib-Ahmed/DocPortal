using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class CompleteBloodCountDetail
    {
        [Key]
        public int CompleteBloodCountDetailId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; }
        public double? Hemoglobin { get; set; }
        public double? Hematocrit { get; set; }
        public double? WhiteBloodCellCount { get; set; }
        public double? RedBloodCellCount { get; set; }
        public double? PlateletCount { get; set; }
        public double? MeanCorpuscularVolume { get; set; }
        public double? MeanCorpuscularHemoglobin { get; set; }
        public double? MeanCorpuscularHemoglobinConcentration { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }



        // Navigation property

        public virtual PatientHealth PatientHealth { get; set; }
    }
}
