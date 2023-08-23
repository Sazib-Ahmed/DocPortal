using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class ThyroidDetail
    {
        [Key]
        public int ThyroidDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public DateTime? RecordedAt { get; set; } // Date and time when the thyroid test was recorded

        public decimal? TSH { get; set; } // Thyroid Stimulating Hormone value

        public decimal? FT4 { get; set; } // Free Thyroxine value

        public decimal? T3 { get; set; } // Total or Free Triiodothyronine value

        public decimal? Calcitonin { get; set; } // Calcitonin value (if applicable)

        public decimal? TPOAntibodies { get; set; } // Anti-thyroid peroxidase antibodies value

        public decimal? TgAntibodies { get; set; } // Anti-thyroglobulin antibodies value
        public string PerformedBy { get; set; }

        public string Note { get; set; }




        // Navigation property
        public virtual PatientHealth PatientHealth { get; set; }
    }
}
