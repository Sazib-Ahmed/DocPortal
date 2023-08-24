namespace DAL.Migrations
{
    using DAL.EF.Models;
    using DAL.EF.Models.PatientHealthDetail;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.DocPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public static string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        protected override void Seed(DAL.EF.DocPortalContext context)
        {
            Random random = new Random();

            // Seed Doctors
            List<Doctor> doctors = new List<Doctor>();
            for (int i = 1; i <= 100; i++)
            {
                doctors.Add(new Doctor
                {
                    Name = "Doctor " + i,
                    Speciality = "Speciality " + random.Next(1, 11),
                    Image = "doctor" + i + ".jpg",
                    Phone = "123-456-7890",
                    Password = EncryptPassword("password" + i),
                    Email = "doctor" + i + "@example.com",
                    Address = "123 Street, City",
                    DateOfBirth = DateTime.Now.AddYears(-30).AddDays(random.Next(-365, 365)),
                    Sex = (Doctor.DGender)random.Next(0, Enum.GetValues(typeof(Doctor.DGender)).Length),
                    Education = "Education for Doctor " + i,
                    ExperienceYears = random.Next(1, 31).ToString(),
                    RegistrationNumber = "Reg" + i,
                    Certifications = "Certifications for Doctor " + i,
                    Description = "Description for Doctor " + i
                });
            }
            context.Doctors.AddRange(doctors);
            context.SaveChanges();



            // Seed Patients
            List<Patient> patients = new List<Patient>();
            for (int i = 1; i <= 100; i++)
            {
                patients.Add(new Patient
                {
                    Name = "Patient " + i,
                    Image = "patient" + i + ".jpg",
                    Phone = "987-654-3210",
                    Password = "password" + i,
                    Email = "patient" + i + "@example.com",
                    Address = "456 Avenue, City",
                    DateOfBirth = DateTime.Now.AddYears(-25).AddDays(random.Next(-365, 365)),
                    Sex = (Patient.PGender)random.Next(0, Enum.GetValues(typeof(Patient.PGender)).Length),
                    Description = "Description for Patient " + i
                });
            }
            context.Patients.AddRange(patients);
            context.SaveChanges();

            // Seed Appointments
            List<Appointment> appointments = new List<Appointment>();
            for (int i = 1; i <= 100; i++)
            {
                appointments.Add(new Appointment
                {
                    PatientId = i,
                    DoctorId = random.Next(1, 101), // Assuming there are 100 doctors
                    AppointmentDate = DateTime.Now.AddDays(random.Next(1, 15)),
                    AppointmentTime = $"{random.Next(9, 18)}:00", // Assuming appointments are between 9 AM and 6 PM
                    Department = "Department " + random.Next(1, 6),
                    Description = "Appointment Description " + i,
                    Status = (AppointmentStatus)random.Next(0, Enum.GetValues(typeof(AppointmentStatus)).Length),
                    CancellationReason = "",
                    IsPaymentConfirmed = true,
                    PaymentConfirmationDate = DateTime.Now
                });
            }
            context.Appointments.AddRange(appointments);
            context.SaveChanges();


            // Seed Prescriptions
            List<Prescription> prescriptions = new List<Prescription>();
            for (int i = 1; i <= 100; i++)
            {
                prescriptions.Add(new Prescription
                {
                    PrescriptionDate = DateTime.Now.AddDays(random.Next(-30, 0)),
                    PatientId = i,
                    DoctorId = random.Next(1, 101), // Assuming there are 100 doctors
                    ChiefComplaint = "Chief Complaint " + i,
                    PhysicalExam = "Physical Examination " + i,
                    Investigation = "Investigation " + i,
                    Diagnosis = "Diagnosis " + i,
                    NextAppointment = DateTime.Now.AddDays(random.Next(1, 15))
                });
            }
            context.Prescriptions.AddRange(prescriptions);
            context.SaveChanges();

            // Seed PrescriptionDetails
            List<PrescriptionDetail> prescriptionDetails = new List<PrescriptionDetail>();
            for (int i = 1; i <= 100; i++)
            {
                prescriptionDetails.Add(new PrescriptionDetail
                {
                    PrescriptionId = i,
                    Medication = "Medication " + i,
                    Dosage = "Dosage " + i,
                    Instructions = "Instructions " + i
                });
            }
            context.PrescriptionDetails.AddRange(prescriptionDetails);
            context.SaveChanges();


            // Seed PatientHealths
            List<PatientHealth> PatientHealths = new List<PatientHealth>();
            for (int i = 1; i <= 100; i++)
            {
                context.PatientHealths.Add(new PatientHealth
                {
                    PatientId = i,
                    BloodType = (PatientHealth.BloodGroup)random.Next(0, Enum.GetValues(typeof(PatientHealth.BloodGroup)).Length),
                    Height = i + 100,
                    IsSmoker = false,
                    HasChronicCondition = false,
                    Allergies = "Allergy " + i,
                    Medications = "Medication " + i
                });
            }
            context.PatientHealths.AddRange(PatientHealths);
            context.SaveChanges();


            List<BloodPressureDetail> BloodPressureDetails = new List<BloodPressureDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.BloodPressureDetails.Add(new BloodPressureDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    SystolicPressure = i + 80,
                    DiastolicPressure = i + 50,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.BloodPressureDetails.AddRange(BloodPressureDetails);
            context.SaveChanges();

            List<CancerMarkersDetail> CancerMarkersDetails = new List<CancerMarkersDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.CancerMarkersDetails.Add(new CancerMarkersDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    CancerMarkersTestData = "Alpha-Fetoprotein and Beta-HCG",
                    Marker1NameAndValue = "Alpha-Fetoprotein " + random.Next(1, 120) + " ng/mL",
                    Marker2NameAndValue = "Beta-HCG " + random.Next(1, 120) + " mIU/mL",
                    TestLocation = "Lab " + random.Next(1, 5),
                    TestDetails = "Test Details " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.CancerMarkersDetails.AddRange(CancerMarkersDetails);
            context.SaveChanges();

            List<CholesterolLevelDetail> CholesterolLevelDetails = new List<CholesterolLevelDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.CholesterolLevelDetails.Add(new CholesterolLevelDetail
                {
                    PatientHealthId = i,
                    TotalCholesterol = random.Next(150, 300),
                    LDLCholesterol = random.Next(100, 200),
                    HDLCholesterol = random.Next(40, 70),
                    Triglycerides = random.Next(50, 150),
                    RecordedAt = DateTime.Now.AddDays(-i),
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.CholesterolLevelDetails.AddRange(CholesterolLevelDetails);
            context.SaveChanges();

            List<CompleteBloodCountDetail> CompleteBloodCountDetails = new List<CompleteBloodCountDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.CompleteBloodCountDetails.Add(new CompleteBloodCountDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    Hemoglobin = random.Next(11, 17),
                    Hematocrit = random.Next(35, 54),
                    WhiteBloodCellCount = random.Next(3000, 11000),
                    RedBloodCellCount = random.Next(4, 5),
                    PlateletCount = random.Next(150000, 450000),
                    MeanCorpuscularVolume = random.Next(80, 100),
                    MeanCorpuscularHemoglobin = random.Next(25, 35),
                    MeanCorpuscularHemoglobinConcentration = random.Next(30, 35),
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.CompleteBloodCountDetails.AddRange(CompleteBloodCountDetails);
            context.SaveChanges();

            List<CTScanDetail> CTScanDetails = new List<CTScanDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.CTScanDetails.Add(new CTScanDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    ScanLocation = "Location " + i,
                    ScanData = "Data " + i,
                    ScanResult = "Result " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.CTScanDetails.AddRange(CTScanDetails);
            context.SaveChanges();

            List<ECGDetail> ECGDetails = new List<ECGDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.ECGDetails.Add(new ECGDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    TestLocation = "Location " + i,
                    TestResult = "Result " + i,
                    ECGData = "Data " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.ECGDetails.AddRange(ECGDetails);
            context.SaveChanges();

            List<GlucoseLevelDetail> GlucoseLevelDetails = new List<GlucoseLevelDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.GlucoseLevelDetails.Add(new GlucoseLevelDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    GlucoseLevel = i + 70,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.GlucoseLevelDetails.AddRange(GlucoseLevelDetails);
            context.SaveChanges();

            List<HemoglobinDetail> HemoglobinDetails = new List<HemoglobinDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.HemoglobinDetails.Add(new HemoglobinDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    HemoglobinLevel = random.Next(11, 17),
                    Hematocrit = random.Next(35, 54),
                    RedBloodCellCount = random.Next(4, 5),
                    MeanCorpuscularVolume = random.Next(80, 100),
                    MeanCorpuscularHemoglobin = random.Next(25, 35),
                    MeanCorpuscularHemoglobinConcentration = random.Next(30, 35),
                    RedCellDistributionWidth = random.Next(12, 15),
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.HemoglobinDetails.AddRange(HemoglobinDetails);
            context.SaveChanges();

            List<ImmunizationHistoryDetail> ImmunizationHistoryDetails = new List<ImmunizationHistoryDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.ImmunizationHistoryDetails.Add(new ImmunizationHistoryDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    VaccineName = "Vaccine " + i,
                    Manufacturer = "Manufacturer " + i,
                    LotNumber = "LOT" + i.ToString().PadLeft(4, '0'),
                    AntibodyLevel = random.Next(100, 1000),
                    AntibodyUnit = "mIU/L",
                    TiterLevel = random.Next(10, 50),
                    TiterUnit = "N/A",
                    ReferenceRange = "Reference " + i,
                    Interpretation = "Interpretation " + i,
                    Recommendations = "Recommendation " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.ImmunizationHistoryDetails.AddRange(ImmunizationHistoryDetails);
            context.SaveChanges();

            List<KidneyFunctionDetail> KidneyFunctionDetails = new List<KidneyFunctionDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.KidneyFunctionDetails.Add(new KidneyFunctionDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    SerumCreatinine = i + 1,
                    BloodUreaNitrogen = i + 2,
                    GlomerularFiltrationRate = i + 3,
                    SerumSodium = i + 4,
                    SerumPotassium = i + 5,
                    SerumChloride = i + 6,
                    SerumAlbumin = i + 7,
                    UrineCreatinine = i + 8,
                    UrineProtein = i + 9,
                    UrineMicroalbumin = i + 10,
                    UrineSodium = i + 11,
                    UrineCreatinineClearance = i + 12,
                    UrineOsmolality = i + 13,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.KidneyFunctionDetails.AddRange(KidneyFunctionDetails);
            context.SaveChanges();


            List<LiverFunctionDetail> LiverFunctionDetails = new List<LiverFunctionDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.LiverFunctionDetails.Add(new LiverFunctionDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    ALT = i + 14,
                    AST = i + 15,
                    ALP = i + 16,
                    GGT = i + 17,
                    TotalBilirubin = i + 18,
                    DirectBilirubin = i + 19,
                    IndirectBilirubin = i + 20,
                    Albumin = i + 21,
                    TotalProtein = i + 22,
                    ProthrombinTime = i + 23,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.LiverFunctionDetails.AddRange(LiverFunctionDetails);
            context.SaveChanges();


            List<MRIDetail> MRIDetails = new List<MRIDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.MRIDetails.Add(new MRIDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    MRILocation = "Location " + i,
                    MRIType = "Type " + i,
                    MRIData = "Data " + i,
                    MachineSerialNumber = "Serial " + i,
                    ReportSummary = "Summary " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.MRIDetails.AddRange(MRIDetails);
            context.SaveChanges();


            List<OtherTestDetail> OtherTestDetails = new List<OtherTestDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.OtherTestDetails.Add(new OtherTestDetail
                {
                    PatientHealthId = i,
                    TestName = "Test " + i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    TestLocation = "Location " + i,
                    TestType = "Type " + i,
                    TestData = "Data " + i,
                    TestSummary = "Summary " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.OtherTestDetails.AddRange(OtherTestDetails);
            context.SaveChanges();


            List<PulmonaryFunctionDetail> PulmonaryFunctionDetails = new List<PulmonaryFunctionDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.PulmonaryFunctionDetails.Add(new PulmonaryFunctionDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    FVC = i + 24,
                    FEV1 = i + 25,
                    PEF = i + 26,
                    FEF2575 = i + 27,
                    TotalLungCapacity = i + 28,
                    ResidualVolume = i + 29,
                    DLCO = i + 30,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.PulmonaryFunctionDetails.AddRange(PulmonaryFunctionDetails);
            context.SaveChanges();

            List<ThyroidDetail> ThyroidDetails = new List<ThyroidDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.ThyroidDetails.Add(new ThyroidDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    TSH = i + 31,
                    FT4 = i + 32,
                    T3 = i + 33,
                    Calcitonin = i + 34,
                    TPOAntibodies = i + 35,
                    TgAntibodies = i + 36,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.ThyroidDetails.AddRange(ThyroidDetails);
            context.SaveChanges();

            List<UrineAnalysisDetail> UrineAnalysisDetails = new List<UrineAnalysisDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.UrineAnalysisDetails.Add(new UrineAnalysisDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    AlanineAminotransferase = i + 37,
                    AspartateAminotransferase = i + 38,
                    AlkalinePhosphatase = i + 39,
                    TotalBilirubin = i + 40,
                    DirectBilirubin = i + 41,
                    IndirectBilirubin = i + 42,
                    Albumin = i + 43,
                    TotalProtein = i + 44,
                    GammaGlutamylTransferase = i + 45,
                    LactateDehydrogenase = i + 46,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.UrineAnalysisDetails.AddRange(UrineAnalysisDetails);
            context.SaveChanges();


            List<VitaminLevelsDetail> VitaminLevelsDetails = new List<VitaminLevelsDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.VitaminLevelsDetails.Add(new VitaminLevelsDetail
                {
                    PatientHealthId = i,
                    VitaminA = i + 51,
                    VitaminD = i + 52,
                    VitaminE = i + 53,
                    VitaminK = i + 54,
                    VitaminB12 = i + 55,
                    Folate = i + 56,
                    VitaminC = i + 57,
                    VitaminB6 = i + 58,
                    Thiamine = i + 59,
                    Riboflavin = i + 60,
                    Niacin = i + 61,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });
            }
            context.VitaminLevelsDetails.AddRange(VitaminLevelsDetails);
            context.SaveChanges();

            List<XrayDetail> XrayDetails = new List<XrayDetail>();
            for (int i = 1; i <= 100; i++)
            {
                context.XrayDetails.Add(new XrayDetail
                {
                    PatientHealthId = i,
                    RecordedAt = DateTime.Now.AddDays(-i),
                    XrayLocation = "Location " + i,
                    XrayType = "Type " + i,
                    XrayData = "Data " + i,
                    MachineSerialNumber = "Serial " + i,
                    XrayTechnicianName = "Technician " + i,
                    ReportSummary = "Summary " + i,
                    PerformedBy = "Doctor",
                    Note = "Note " + i
                });

            }
            context.XrayDetails.AddRange(XrayDetails);
            context.SaveChanges();
        }
    }
}
