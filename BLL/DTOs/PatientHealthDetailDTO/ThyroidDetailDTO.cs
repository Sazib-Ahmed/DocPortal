using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientHealthDetailDTO
{
    public class ThyroidDetailDTO
    {
        public int ThyroidDetailId { get; set; }
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; } // Date and time when the thyroid test was recorded

        public decimal? TSH { get; set; } // Thyroid Stimulating Hormone value

        public decimal? FT4 { get; set; } // Free Thyroxine value

        public decimal? T3 { get; set; } // Total or Free Triiodothyronine value

        public decimal? Calcitonin { get; set; } // Calcitonin value (if applicable)

        public decimal? TPOAntibodies { get; set; } // Anti-thyroid peroxidase antibodies value

        public decimal? TgAntibodies { get; set; } // Anti-thyroglobulin antibodies value
        public string PerformedBy { get; set; }

        public string Note { get; set; }
    }
}
