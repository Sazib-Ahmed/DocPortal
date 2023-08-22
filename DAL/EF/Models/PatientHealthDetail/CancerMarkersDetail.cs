using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class CancerMarkersDetail
    {
        [Key]
        public int CancerMarkersDetailId { get; set; }



        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }




        public virtual PatientHealth PatientHealth { get; set; }
    }
}
