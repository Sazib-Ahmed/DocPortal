using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Patient
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Sex { get; set; }



        public string Description { get; set; }

        // Navigation property
        public virtual ICollection<Prescription> Prescription { get; set; }

        public enum Gender
        {
            Male,
            Female,
            Other
        }

    }
}
