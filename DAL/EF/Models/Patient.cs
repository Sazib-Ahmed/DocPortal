using DAL.EF.Models.PatientHealthDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Patient
    {
        [Key] // Specify the primary key

        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PGender Sex { get; set; }
        public string Description { get; set; }

        //Navigation property
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<PatientHealth> PatientHealths { get; set; }


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

        public Patient()
        {
            Prescriptions = new List<Prescription>();
            Appointments = new List<Appointment>();
            PatientHealths = new List<PatientHealth>();

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


        public enum PGender
        {
            Male,
            Female,
            Other
        }

    }
}
