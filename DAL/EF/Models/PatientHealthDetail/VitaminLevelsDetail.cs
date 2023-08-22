using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.PatientHealthDetail
{
    public class VitaminLevelsDetail
    {
        [Key]
        public int VitaminLevelsDetailId { get; set; }

        [ForeignKey("PatientHealth")]
        public int PatientHealthId { get; set; }





        // Navigation property

        public virtual PatientHealth PatientHealth { get; set; }
    }
}
