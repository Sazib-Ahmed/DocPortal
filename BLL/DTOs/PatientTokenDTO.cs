using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientTokenDTO
    {
        public int PatientTokenId { get; set; }
        public int PatientId { get; set; }
        public string TokenKey { get; set; }
        public int? RetrievalCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public DateTime? LastUsedAt { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string Purpose { get; set; }



    }
}
