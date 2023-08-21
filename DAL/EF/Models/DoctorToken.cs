using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class DoctorToken
    {
        [Key]
        public int DoctorTokenId { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        public string TokenKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string Purpose { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
