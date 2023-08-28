using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class PulmonaryFunctionDetail
    {
        [Key]
        public int PulmonaryFunctionDetailId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; } // Date and time when the test was recorded

        public double? FVC { get; set; } // Forced Vital Capacity
        public double? FEV1 { get; set; } // Forced Expiratory Volume in 1 second
        public double? PEF { get; set; } // Peak Expiratory Flow
        public double? FEF2575 { get; set; } // Mid-Expiratory Flow (25-75%)
        public double? TotalLungCapacity { get; set; }
        public double? ResidualVolume { get; set; }
        public double? DLCO { get; set; } // Diffusion Capacity of Carbon Monoxide
        public string PerformedBy { get; set; }

        public string Note { get; set; }




        // Navigation properties
        public virtual Patient Patient { get; set; }
    }
}
