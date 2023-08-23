using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.EF.Models.PatientHealth;

namespace BLL.DTOs
{
    public class PatientHealthDTO
    {
        public int PatientHealthId { get; set; }

        public int PatientId { get; set; }

        public BloodGroup? BloodType { get; set; }

        public double? Height { get; set; }

        public bool? IsSmoker { get; set; }

        public bool? HasChronicCondition { get; set; }

        public string Allergies { get; set; }

        public string Medications { get; set; }

    }
}
