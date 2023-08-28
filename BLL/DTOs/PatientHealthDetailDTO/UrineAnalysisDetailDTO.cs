using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class UrineAnalysisDetailDTO
    {
        public int UrineAnalysisDetailId { get; set; }
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; }  // DateTime when the test was performed
        public double? AlanineAminotransferase { get; set; }  // ALT level
        public double? AspartateAminotransferase { get; set; }  // AST level
        public double? AlkalinePhosphatase { get; set; }  // ALP level
        public double? TotalBilirubin { get; set; }  // Total bilirubin level
        public double? DirectBilirubin { get; set; }  // Direct bilirubin level
        public double? IndirectBilirubin { get; set; }  // Indirect bilirubin level
        public double? Albumin { get; set; }  // Albumin level
        public double? TotalProtein { get; set; }  // Total protein level
        public double? GammaGlutamylTransferase { get; set; }  // GGT level
        public double? LactateDehydrogenase { get; set; }  // LDH level
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
