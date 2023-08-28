using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DoctorWithImageDTO
    {
        public DoctorDTO DoctorDTO { get; set; }
        public byte[] ImageData { get; set; }
    }
}
