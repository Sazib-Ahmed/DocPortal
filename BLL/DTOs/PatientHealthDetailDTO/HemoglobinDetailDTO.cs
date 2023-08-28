using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class HemoglobinDetailDTO
    {
        public int HemoglobinDetailId { get; set; }
        public int PatientId { get; set; }

        public DateTime RecordedAt { get; set; }  
        public double? HemoglobinLevel { get; set; }  // in g/dL
        public double? Hematocrit { get; set; }       // in percentage
        public double? RedBloodCellCount { get; set; }  // in million/μL
        public double? MeanCorpuscularVolume { get; set; }  // in fL
        public double? MeanCorpuscularHemoglobin { get; set; }  // in pg
        public double? MeanCorpuscularHemoglobinConcentration { get; set; }  // in g/dL
        public double? RedCellDistributionWidth { get; set; }  // in percentage
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
