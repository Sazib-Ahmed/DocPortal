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

        public BloodGroup BloodType { get; set; }

        public string Height { get; set; } 

        public bool IsSmoker { get; set; }

        public bool HasChronicCondition { get; set; }

        public string Allergies { get; set; }

        public string OnMedications { get; set; }


        public virtual Patient Patient { get; set; }



        // Navigation property 

        public virtual ICollection<BloodPressureDetail> BloodPressureDetails { get; set; }
        public virtual ICollection<HemoglobinDetail> HemoglobinDetails { get; set; }
        public virtual ICollection<XrayDetail> XrayDetails { get; set; }
        public virtual ICollection<MRIDetail> MRIDetails { get; set; }
        public virtual ICollection<CTScanDetail> CTScanDetails { get; set; }
        public virtual ICollection<GlucoseLevelDetail> GlucoseLevelDetails { get; set; }
        public virtual ICollection<CholesterolLevelDetail> CholesterolLevelDetails { get; set; }
        public virtual ICollection<ThyroidDetail> ThyroidDetails { get; set; }
        public virtual ICollection<LiverFunctionDetail> LiverFunctionDetails { get; set; }
        public virtual ICollection<KidneyFunctionDetail> KidneyFunctionDetails { get; set; }
        public virtual ICollection<CompleteBloodCountDetail> CompleteBloodCountDetails { get; set; }
        public virtual ICollection<UrineAnalysisDetail> UrineAnalysisDetails { get; set; }
        public virtual ICollection<ECGDetail> ECGDetails { get; set; }
        public virtual ICollection<PulmonaryFunctionDetail> PulmonaryFunctionDetails { get; set; }
        public virtual ICollection<VitaminLevelsDetail> VitaminLevelsDetails { get; set; }
        public virtual ICollection<CancerMarkersDetail> CancerMarkersDetails { get; set; }
        public virtual ICollection<ImmunizationHistoryDetail> ImmunizationHistoryDetails { get; set; }
        public virtual ICollection<OtherTestDetail> OtherTestDetails { get; set; }
        


        public PatientHealth()
        {

            BloodPressureDetails = new List<BloodPressureDetail>();
            HemoglobinDetails = new List<HemoglobinDetail>();
            XrayDetails = new List<XrayDetail>();
            MRIDetails = new List<MRIDetail>();
            CTScanDetails = new List<CTScanDetail>();
            GlucoseLevelDetails = new List<GlucoseLevelDetail>();
            CholesterolLevelDetails = new List<CholesterolLevelDetail>();
            ThyroidDetails = new List<ThyroidDetail>();
            LiverFunctionDetails = new List<LiverFunctionDetail>();
            KidneyFunctionDetails = new List<KidneyFunctionDetail>();
            CompleteBloodCountDetails = new List<CompleteBloodCountDetail>();
            UrineAnalysisDetails = new List<UrineAnalysisDetail>();
            ECGDetails = new List<ECGDetail>();
            PulmonaryFunctionDetails = new List<PulmonaryFunctionDetail>();
            VitaminLevelsDetails = new List<VitaminLevelsDetail>();
            CancerMarkersDetails = new List<CancerMarkersDetail>();
            ImmunizationHistoryDetails = new List<ImmunizationHistoryDetail>();
            OtherTestDetails = new List<OtherTestDetail>();

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
