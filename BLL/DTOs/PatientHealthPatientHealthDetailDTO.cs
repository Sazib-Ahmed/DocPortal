using DAL.EF.Models.PatientHealthDetail;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientHealthPatientHealthDetailDTO : PatientHealthDTO
    {
        public List<BloodPressureDetail> BloodPressureDetails { get; set; }
        public List<HemoglobinDetail> HemoglobinDetails { get; set; }
        public List<XrayDetail> XrayDetails { get; set; }
        public List<MRIDetail> MRIDetails { get; set; }
        public List<CTScanDetail> CTScanDetails { get; set; }
        public List<GlucoseLevelDetail> GlucoseLevelDetails { get; set; }
        public List<CholesterolLevelDetail> CholesterolLevelDetails { get; set; }
        public List<ThyroidDetail> ThyroidDetails { get; set; }
        public List<LiverFunctionDetail> LiverFunctionDetails { get; set; }
        public List<KidneyFunctionDetail> KidneyFunctionDetails { get; set; }
        public List<CompleteBloodCountDetail> CompleteBloodCountDetails { get; set; }
        public List<UrineAnalysisDetail> UrineAnalysisDetails { get; set; }
        public List<ECGDetail> ECGDetails { get; set; }
        public List<PulmonaryFunctionDetail> PulmonaryFunctionDetails { get; set; }
        public List<VitaminLevelsDetail> VitaminLevelsDetails { get; set; }
        public List<CancerMarkersDetail> CancerMarkersDetails { get; set; }
        public List<ImmunizationHistoryDetail> ImmunizationHistoryDetails { get; set; }
        public List<OtherTestDetail> OtherTestDetails { get; set; }

        public PatientHealthPatientHealthDetailDTO()
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
    }
}