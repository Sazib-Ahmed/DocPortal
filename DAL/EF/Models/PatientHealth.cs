using DAL.EF.Models.PatientHealthDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models
{
    public class PatientHealth
    {
        [Key]
        public int PatientHealthId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public BloodGroup? BloodType { get; set; }

        public double? Height { get; set; } 

        public bool? IsSmoker { get; set; }

        public bool? HasChronicCondition { get; set; }

        public string Allergies { get; set; }

        public string Medications { get; set; }


        public virtual Patient Patient { get; set; }



        // Navigation property 

        
        


        public PatientHealth()
        {

            

        }


        public enum BloodGroup
        {
            APositive,
            ANegative,
            BPositive,
            BNegative,
            ABPositive,
            ABNegative,
            OPositive,
            ONegative,
        }
    }
}
