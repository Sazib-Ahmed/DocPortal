using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class BloodPressureDetail
    {
        [Key]
        public int BloodPressureDetailId { get; set; } 
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public DateTime? RecordedAt { get; set; }
        public int? SystolicPressure { get; set; }
        public int? DiastolicPressure { get; set; }
        public string PerformedBy { get; set; }
        public string Note { get; set; }


        
        public virtual Patient Patient { get; set; }
    }
}
