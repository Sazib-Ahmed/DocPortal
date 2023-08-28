using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class RequestSchedule
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Appointment")]
        [Required]
        public int Pid { get; set; }
        public DateTime VisitTime { get; set; }

    }
}
