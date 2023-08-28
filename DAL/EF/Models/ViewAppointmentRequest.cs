using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class ViewAppointmentRequest
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Appointment")]
        [Required]
        public int PId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
