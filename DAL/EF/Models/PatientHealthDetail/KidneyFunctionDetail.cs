using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class KidneyFunctionDetail
    {
        [Key]
        public int KidneyFunctionDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }
        public DateTime? RecordedAt { get; set; } // Date and time when the test was recorded

        public double? SerumCreatinine { get; set; } // Serum creatinine level

        public double? BloodUreaNitrogen { get; set; } // Blood urea nitrogen level

        public double? GlomerularFiltrationRate { get; set; } // GFR value

        public double? SerumSodium { get; set; } // Serum sodium level

        public double? SerumPotassium { get; set; } // Serum potassium level

        public double? SerumChloride { get; set; } // Serum chloride level

        public double? SerumAlbumin { get; set; } // Serum albumin level

        public double? UrineCreatinine { get; set; } // Urine creatinine level

        public double? UrineProtein { get; set; } // Urine protein level

        public double? UrineMicroalbumin { get; set; } // Urine microalbumin level

        public double? UrineSodium { get; set; } // Urine sodium level

        public double? UrineCreatinineClearance { get; set; } // Urine creatinine clearance value

        public double? UrineOsmolality { get; set; } // Urine osmolality value
        public string PerformedBy { get; set; }

        public string Note { get; set; }




        public virtual PatientHealth PatientHealth { get; set; }
    }
}
