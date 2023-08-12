using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PrescriptionPrescriptionDetailDTO : PrescriptionDTO
    {
        public List<PrescriptionDetailDTO> PrescriptionDetails { get; set; }
        public PrescriptionPrescriptionDetailDTO()
        {
            PrescriptionDetails = new List<PrescriptionDetailDTO>();
        }
    }
}
 