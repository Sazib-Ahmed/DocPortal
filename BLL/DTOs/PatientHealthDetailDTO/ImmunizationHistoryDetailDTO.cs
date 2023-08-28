using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class ImmunizationHistoryDetailDTO
    {
        public int ImmunizationHistoryDetailId { get; set; }
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }  // Date and time when the immunization test was conducted

        public string VaccineName { get; set; }  // Name of the administered vaccine
        public string Manufacturer { get; set; }  // Manufacturer of the vaccine
        public string LotNumber { get; set; }  // Lot number of the vaccine

        public double? AntibodyLevel { get; set; }  // Measurement of antibody levels
        public string AntibodyUnit { get; set; }  // Unit of measurement for antibody levels (e.g., IU/mL)

        public double? TiterLevel { get; set; }  // Measurement of titer levels
        public string TiterUnit { get; set; }  // Unit of measurement for titer levels (e.g., 1:128)

        public string ReferenceRange { get; set; }  // Reference range for interpreting the results

        public string Interpretation { get; set; }  // Interpretation of the immunization test results
        public string Recommendations { get; set; }  // Recommendations based on the results
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
