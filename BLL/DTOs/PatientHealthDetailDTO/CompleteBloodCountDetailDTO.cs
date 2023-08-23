using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class CompleteBloodCountDetailDTO
    {
        public int CompleteBloodCountDetailId { get; set; }
        public int PatientHealthId { get; set; }
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
    }
}
