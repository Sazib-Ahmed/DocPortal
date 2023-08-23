using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PatientToken
    {

        [Key]
        public int PatientTokenId { get; set; }
       

        [ForeignKey("Patient")]
        public int PatientId { get; set; }


        public string TokenKey { get; set; }

        public int? RetrievalCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
       

        public virtual Patient Patient { get; set; }
    }
}
