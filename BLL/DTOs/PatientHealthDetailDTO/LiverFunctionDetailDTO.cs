using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class LiverFunctionDetailDTO
    {
        public int LiverFunctionDetailId { get; set; }
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }  // Date and time when the test was recorded

        public double? ALT { get; set; }  // Alanine Aminotransferase
        public double? AST { get; set; }  // Aspartate Aminotransferase
        public double? ALP { get; set; }  // Alkaline Phosphatase
        public double? GGT { get; set; }  // Gamma-Glutamyl Transferase
        public double? TotalBilirubin { get; set; }
        public double? DirectBilirubin { get; set; }
        public double? IndirectBilirubin { get; set; }
        public double? Albumin { get; set; }
        public double? TotalProtein { get; set; }
        public double? ProthrombinTime { get; set; }  // or INR (International Normalized Ratio)

        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
