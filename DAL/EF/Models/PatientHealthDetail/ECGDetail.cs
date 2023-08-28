using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class ECGDetail
    {
        [Key]
        public int ECGDetailId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public DateTime? RecordedAt { get; set; }

        public string TestLocation { get; set; }

        public string TestResult { get; set; }

        public string ECGData { get; set; }
        public string PerformedBy { get; set; }

        public string Note { get; set; }



        public virtual Patient Patient { get; set; }
    }
}
