using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PrescriptionDetail
    {
        public int PrescriptionDetailId { get; set; }
        [ForeignKey("Prescription")]
        public int PrescriptionId { get; set; }
        public string Medication { get; set; }
        public string Dosage { get; set; }
        public string Instructions { get; set; }

        // Navigation property
        public virtual Prescription Prescription { get; set; }

    }
}
