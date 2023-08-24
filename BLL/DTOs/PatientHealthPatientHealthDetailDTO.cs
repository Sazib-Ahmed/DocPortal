
using BLL.DTOs.PatientHealthDetailDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientHealthPatientHealthDetailDTO : PatientHealthDTO
    {
        public List<BloodPressureDetailDTO> BloodPressureDetails { get; set; }
        public List<HemoglobinDetailDTO> HemoglobinDetails { get; set; }
        public List<XrayDetailDTO> XrayDetails { get; set; }
        public List<MRIDetailDTO> MRIDetails { get; set; }
        public List<CTScanDetailDTO> CTScanDetails { get; set; }
        public List<GlucoseLevelDetailDTO> GlucoseLevelDetails { get; set; }
        public List<CholesterolLevelDetailDTO> CholesterolLevelDetails { get; set; }
        public List<ThyroidDetailDTO> ThyroidDetails { get; set; }
        public List<LiverFunctionDetailDTO> LiverFunctionDetails { get; set; }
        public List<KidneyFunctionDetailDTO> KidneyFunctionDetails { get; set; }
        public List<CompleteBloodCountDetailDTO> CompleteBloodCountDetails { get; set; }
        public List<UrineAnalysisDetailDTO> UrineAnalysisDetails { get; set; }
        public List<ECGDetailDTO> ECGDetails { get; set; }
        public List<PulmonaryFunctionDetailDTO> PulmonaryFunctionDetails { get; set; }
        public List<VitaminLevelsDetailDTO> VitaminLevelsDetails { get; set; }
        public List<CancerMarkersDetailDTO> CancerMarkersDetails { get; set; }
        public List<ImmunizationHistoryDetailDTO> ImmunizationHistoryDetails { get; set; }
        public List<OtherTestDetailDTO> OtherTestDetails { get; set; }

        public PatientHealthPatientHealthDetailDTO()
        {
            BloodPressureDetails = new List<BloodPressureDetailDTO>();
            HemoglobinDetails = new List<HemoglobinDetailDTO>();
            XrayDetails = new List<XrayDetailDTO>();
            MRIDetails = new List<MRIDetailDTO>();
            CTScanDetails = new List<CTScanDetailDTO>();
            GlucoseLevelDetails = new List<GlucoseLevelDetailDTO>();
            CholesterolLevelDetails = new List<CholesterolLevelDetailDTO>();
            ThyroidDetails = new List<ThyroidDetailDTO>();
            LiverFunctionDetails = new List<LiverFunctionDetailDTO>();
            KidneyFunctionDetails = new List<KidneyFunctionDetailDTO>();
            CompleteBloodCountDetails = new List<CompleteBloodCountDetailDTO>();
            UrineAnalysisDetails = new List<UrineAnalysisDetailDTO>();
            ECGDetails = new List<ECGDetailDTO>();
            PulmonaryFunctionDetails = new List<PulmonaryFunctionDetailDTO>();
            VitaminLevelsDetails = new List<VitaminLevelsDetailDTO>();
            CancerMarkersDetails = new List<CancerMarkersDetailDTO>();
            ImmunizationHistoryDetails = new List<ImmunizationHistoryDetailDTO>();
            OtherTestDetails = new List<OtherTestDetailDTO>();

        }
    }
}