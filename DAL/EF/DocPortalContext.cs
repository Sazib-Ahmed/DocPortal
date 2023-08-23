using DAL.EF.Models;
using DAL.EF.Models.PatientHealthDetail;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class DocPortalContext : DbContext

    {

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorToken> DoctorTokens { get; set; }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public DbSet<PatientHealth> PatientHealths { get; set; }
        public DbSet<BloodPressureDetail> BloodPressureDetails { get; set; }
        public DbSet<HemoglobinDetail> HemoglobinDetails { get; set; }
        public DbSet<XrayDetail> XrayDetails { get; set; }
        public DbSet<MRIDetail> MRIDetails { get; set; }
        public DbSet<CTScanDetail> CTScanDetails { get; set; }
        public DbSet<GlucoseLevelDetail> GlucoseLevelDetails { get; set; }
        public DbSet<CholesterolLevelDetail> CholesterolLevelDetails { get; set; }
        public DbSet<ThyroidDetail> ThyroidDetails { get; set; }
        public DbSet<LiverFunctionDetail> LiverFunctionDetails { get; set; }
        public DbSet<KidneyFunctionDetail> KidneyFunctionDetails { get; set; }
        public DbSet<CompleteBloodCountDetail> CompleteBloodCountDetails { get; set; }
        public DbSet<UrineAnalysisDetail> UrineAnalysisDetails { get; set; }
        public DbSet<ECGDetail> ECGDetails { get; set; }
        public DbSet<PulmonaryFunctionDetail> PulmonaryFunctionDetails { get; set; }
        public DbSet<VitaminLevelsDetail> VitaminLevelsDetails { get; set; }
        public DbSet<CancerMarkersDetail> CancerMarkersDetails { get; set; }
        public DbSet<ImmunizationHistoryDetail> ImmunizationHistoryDetails { get; set; }
        public DbSet<OtherTestDetail> OtherTestDetails { get; set; }
        



        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<PatientToken> PatientTokens { get; set; }
    }
}
