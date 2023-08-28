using DAL.EF.Models;
using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using DAL.Repo;
using DAL.Repo.PatientHealthDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Doctor, int, bool> DoctorData()
        {
            return new DoctorRepo();
        }

        public static IAuth<Doctor> DoctorAuthData()
        {
            return new DoctorRepo();
        }

        public static IImageHandler<byte[], string, bool> PutDoctorImageData()
        {
            return new DoctorRepo();
        }

        public static IImageHandler<byte[], string, bool> GetDoctorImageData()
        {
            return new DoctorRepo();
        }

        public static IRepo<DoctorToken, int, DoctorToken> DoctorTokenData()
        {
            return new DoctorTokenRepo();
        }
        public static IRepo<Prescription, int, bool> PrescriptionData()
        {
            return new PrescriptionRepo();
        }
        public static IRepo<PrescriptionDetail, int, bool> PrescriptionDetailData()
        {
            return new PrescriptionDetailRepo();
        }
        public static IRepo<PatientHealth, int, bool> PatientHealthData()
        {
            return new PatientHealthRepo();
        }
        //===================================================================================================


        public static IRepo<BloodPressureDetail, int, bool> BloodPressureDetailData()
        {
            return new BloodPressureDetailRepo();
        }

        public static IRepo<HemoglobinDetail, int, bool> HemoglobinDetailData()
        {
            return new HemoglobinDetailRepo();
        }

        public static IRepo<XrayDetail, int, bool> XrayDetailData()
        {
            return new XrayDetailRepo();
        }

        public static IRepo<MRIDetail, int, bool> MRIDetailData()
        {
            return new MRIDetailRepo();
        }

        public static IRepo<CTScanDetail, int, bool> CTScanDetailData()
        {
            return new CTScanDetailRepo();
        }

        public static IRepo<GlucoseLevelDetail, int, bool> GlucoseLevelDetailData()
        {
            return new GlucoseLevelDetailRepo();
        }

        public static IRepo<CholesterolLevelDetail, int, bool> CholesterolLevelDetailData()
        {
            return new CholesterolLevelDetailRepo();
        }

        public static IRepo<ThyroidDetail, int, bool> ThyroidDetailData()
        {
            return new ThyroidDetailRepo();
        }
        public static IRepo<LiverFunctionDetail, int, bool> LiverFunctionDetailData()
        {
            return new LiverFunctionDetailRepo();
        }

        public static IRepo<KidneyFunctionDetail, int, bool> KidneyFunctionDetailData()
        {
            return new KidneyFunctionDetailRepo();
        }

        public static IRepo<CompleteBloodCountDetail, int, bool> CompleteBloodCountDetailData()
        {
            return new CompleteBloodCountDetailRepo();
        }

        public static IRepo<UrineAnalysisDetail, int, bool> UrineAnalysisDetailData()
        {
            return new UrineAnalysisDetailRepo();
        }

        public static IRepo<ECGDetail, int, bool> ECGDetailData()
        {
            return new ECGDetailRepo();
        }

        public static IRepo<PulmonaryFunctionDetail, int, bool> PulmonaryFunctionDetailData()
        {
            return new PulmonaryFunctionDetailRepo();
        }

        public static IRepo<VitaminLevelsDetail, int, bool> VitaminLevelsDetailData()
        {
            return new VitaminLevelsDetailRepo();
        }

        public static IRepo<CancerMarkersDetail, int, bool> CancerMarkersDetailData()
        {
            return new CancerMarkersDetailRepo();
        }

        public static IRepo<ImmunizationHistoryDetail, int, bool> ImmunizationHistoryDetailData()
        {
            return new ImmunizationHistoryDetailRepo();
        }

        public static IRepo<OtherTestDetail, int, bool> OtherTestDetailData()
        {
            return new OtherTestDetailRepo();
        }


        //===================================================================================================
        public static IRepo<Patient, int, bool> PatientData()
        {
            return new PatientRepo();

        }
        public static IAuth<Patient> PatientAuthData()
        {
            return new PatientRepo();
        }

        public static IRepo<Appointment, int, bool> AppointmentData()
        {
            return new AppointmentRepo();
        }

        public static IRepo<Assistant, int, Assistant> AssistantData()
        {
            return new AssistantRepo();
        }
        public static IRepo<PatientToken, int, PatientToken> PatientTokenData()
        {
            return new PatientTokenRepo();
        }

    }

}
