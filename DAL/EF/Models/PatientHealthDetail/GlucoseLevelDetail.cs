using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class GlucoseLevelDetail
    {
        [Key]
        public int GlucoseLevelDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }

        public double? GlucoseLevel { get; set; }

        public DateTime? RecordedAt { get; set; }

        public virtual PatientHealth PatientHealth { get; set; }
    }
}
