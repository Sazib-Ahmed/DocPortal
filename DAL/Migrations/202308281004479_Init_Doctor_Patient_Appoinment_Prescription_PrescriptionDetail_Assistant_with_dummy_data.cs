namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_Doctor_Patient_Appoinment_Prescription_PrescriptionDetail_Assistant_with_dummy_data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                        AppointmentTime = c.String(),
                        Department = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        CancellationReason = c.String(),
                        IsPaymentConfirmed = c.Boolean(nullable: false),
                        PaymentConfirmationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Speciality = c.String(),
                        Image = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(),
                        Sex = c.Int(),
                        Education = c.String(),
                        ExperienceYears = c.String(),
                        RegistrationNumber = c.String(),
                        Certifications = c.String(),
                        Description = c.String(),
                        FailedLoginAttempts = c.Int(),
                        LockoutEnd = c.DateTime(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PrescriptionDate = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        ChiefComplaint = c.String(),
                        PhysicalExam = c.String(),
                        Investigation = c.String(),
                        Diagnosis = c.String(),
                        NextAppointment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.BloodPressureDetails",
                c => new
                    {
                        BloodPressureDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        SystolicPressure = c.Int(),
                        DiastolicPressure = c.Int(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.BloodPressureDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.CancerMarkersDetails",
                c => new
                    {
                        CancerMarkersDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        CancerMarkersTestData = c.String(),
                        Marker1NameAndValue = c.String(),
                        Marker2NameAndValue = c.String(),
                        TestLocation = c.String(),
                        TestDetails = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CancerMarkersDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.CholesterolLevelDetails",
                c => new
                    {
                        CholesterolLevelDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        TotalCholesterol = c.Double(nullable: false),
                        LDLCholesterol = c.Double(nullable: false),
                        HDLCholesterol = c.Double(nullable: false),
                        Triglycerides = c.Double(nullable: false),
                        RecordedAt = c.DateTime(nullable: false),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CholesterolLevelDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.CompleteBloodCountDetails",
                c => new
                    {
                        CompleteBloodCountDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        Hemoglobin = c.Double(),
                        Hematocrit = c.Double(),
                        WhiteBloodCellCount = c.Double(),
                        RedBloodCellCount = c.Double(),
                        PlateletCount = c.Double(),
                        MeanCorpuscularVolume = c.Double(),
                        MeanCorpuscularHemoglobin = c.Double(),
                        MeanCorpuscularHemoglobinConcentration = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CompleteBloodCountDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.CTScanDetails",
                c => new
                    {
                        CTScanDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        ScanLocation = c.String(),
                        ScanData = c.String(),
                        ScanResult = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CTScanDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.ECGDetails",
                c => new
                    {
                        ECGDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        TestLocation = c.String(),
                        TestResult = c.String(),
                        ECGData = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ECGDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.GlucoseLevelDetails",
                c => new
                    {
                        GlucoseLevelDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        GlucoseLevel = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.GlucoseLevelDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.HemoglobinDetails",
                c => new
                    {
                        HemoglobinDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(nullable: false),
                        HemoglobinLevel = c.Double(),
                        Hematocrit = c.Double(),
                        RedBloodCellCount = c.Double(),
                        MeanCorpuscularVolume = c.Double(),
                        MeanCorpuscularHemoglobin = c.Double(),
                        MeanCorpuscularHemoglobinConcentration = c.Double(),
                        RedCellDistributionWidth = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.HemoglobinDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.ImmunizationHistoryDetails",
                c => new
                    {
                        ImmunizationHistoryDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        VaccineName = c.String(),
                        Manufacturer = c.String(),
                        LotNumber = c.String(),
                        AntibodyLevel = c.Double(),
                        AntibodyUnit = c.String(),
                        TiterLevel = c.Double(),
                        TiterUnit = c.String(),
                        ReferenceRange = c.String(),
                        Interpretation = c.String(),
                        Recommendations = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ImmunizationHistoryDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.KidneyFunctionDetails",
                c => new
                    {
                        KidneyFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        SerumCreatinine = c.Double(),
                        BloodUreaNitrogen = c.Double(),
                        GlomerularFiltrationRate = c.Double(),
                        SerumSodium = c.Double(),
                        SerumPotassium = c.Double(),
                        SerumChloride = c.Double(),
                        SerumAlbumin = c.Double(),
                        UrineCreatinine = c.Double(),
                        UrineProtein = c.Double(),
                        UrineMicroalbumin = c.Double(),
                        UrineSodium = c.Double(),
                        UrineCreatinineClearance = c.Double(),
                        UrineOsmolality = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.KidneyFunctionDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.LiverFunctionDetails",
                c => new
                    {
                        LiverFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        ALT = c.Double(),
                        AST = c.Double(),
                        ALP = c.Double(),
                        GGT = c.Double(),
                        TotalBilirubin = c.Double(),
                        DirectBilirubin = c.Double(),
                        IndirectBilirubin = c.Double(),
                        Albumin = c.Double(),
                        TotalProtein = c.Double(),
                        ProthrombinTime = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.LiverFunctionDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.MRIDetails",
                c => new
                    {
                        MRIDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        MRILocation = c.String(),
                        MRIType = c.String(),
                        MRIData = c.String(),
                        MachineSerialNumber = c.String(),
                        ReportSummary = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.MRIDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.OtherTestDetails",
                c => new
                    {
                        OtherTestDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        TestName = c.String(),
                        RecordedAt = c.DateTime(),
                        TestLocation = c.String(),
                        TestType = c.String(),
                        TestData = c.String(),
                        PerformedBy = c.String(),
                        TestSummary = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.OtherTestDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.PatientHealths",
                c => new
                    {
                        PatientHealthId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        BloodType = c.Int(),
                        Height = c.Double(),
                        IsSmoker = c.Boolean(),
                        HasChronicCondition = c.Boolean(),
                        Allergies = c.String(),
                        Medications = c.String(),
                    })
                .PrimaryKey(t => t.PatientHealthId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.PulmonaryFunctionDetails",
                c => new
                    {
                        PulmonaryFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        FVC = c.Double(),
                        FEV1 = c.Double(),
                        PEF = c.Double(),
                        FEF2575 = c.Double(),
                        TotalLungCapacity = c.Double(),
                        ResidualVolume = c.Double(),
                        DLCO = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.PulmonaryFunctionDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.ThyroidDetails",
                c => new
                    {
                        ThyroidDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        TSH = c.Decimal(precision: 18, scale: 2),
                        FT4 = c.Decimal(precision: 18, scale: 2),
                        T3 = c.Decimal(precision: 18, scale: 2),
                        Calcitonin = c.Decimal(precision: 18, scale: 2),
                        TPOAntibodies = c.Decimal(precision: 18, scale: 2),
                        TgAntibodies = c.Decimal(precision: 18, scale: 2),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ThyroidDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.UrineAnalysisDetails",
                c => new
                    {
                        UrineAnalysisDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        AlanineAminotransferase = c.Double(),
                        AspartateAminotransferase = c.Double(),
                        AlkalinePhosphatase = c.Double(),
                        TotalBilirubin = c.Double(),
                        DirectBilirubin = c.Double(),
                        IndirectBilirubin = c.Double(),
                        Albumin = c.Double(),
                        TotalProtein = c.Double(),
                        GammaGlutamylTransferase = c.Double(),
                        LactateDehydrogenase = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.UrineAnalysisDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.VitaminLevelsDetails",
                c => new
                    {
                        VitaminLevelsDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        VitaminA = c.Double(),
                        VitaminD = c.Double(),
                        VitaminE = c.Double(),
                        VitaminK = c.Double(),
                        VitaminB12 = c.Double(),
                        Folate = c.Double(),
                        VitaminC = c.Double(),
                        VitaminB6 = c.Double(),
                        Thiamine = c.Double(),
                        Riboflavin = c.Double(),
                        Niacin = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.VitaminLevelsDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.XrayDetails",
                c => new
                    {
                        XrayDetailId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        XrayLocation = c.String(),
                        XrayType = c.String(),
                        XrayData = c.String(),
                        MachineSerialNumber = c.String(),
                        XrayTechnicianName = c.String(),
                        ReportSummary = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.XrayDetailId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.PrescriptionDetails",
                c => new
                    {
                        PrescriptionDetailId = c.Int(nullable: false, identity: true),
                        PrescriptionId = c.Int(nullable: false),
                        Medication = c.String(),
                        Dosage = c.String(),
                        Instructions = c.String(),
                    })
                .PrimaryKey(t => t.PrescriptionDetailId)
                .ForeignKey("dbo.Prescriptions", t => t.PrescriptionId, cascadeDelete: true)
                .Index(t => t.PrescriptionId);
            
            CreateTable(
                "dbo.Assistants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Nid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoctorTokens",
                c => new
                    {
                        DoctorTokenId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        TokenKey = c.String(),
                        RetrievalCount = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        LastUsedAt = c.DateTime(),
                        IpAddress = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Purpose = c.String(),
                    })
                .PrimaryKey(t => t.DoctorTokenId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.PatientTokens",
                c => new
                    {
                        PatientTokenId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        TokenKey = c.String(),
                        RetrievalCount = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        LastUsedAt = c.DateTime(),
                        IpAddress = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PatientTokenId)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientTokens", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.DoctorTokens", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.PrescriptionDetails", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.XrayDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.VitaminLevelsDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.UrineAnalysisDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.ThyroidDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PulmonaryFunctionDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientHealths", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.OtherTestDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.MRIDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.LiverFunctionDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.KidneyFunctionDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.ImmunizationHistoryDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.HemoglobinDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.GlucoseLevelDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.ECGDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.CTScanDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.CompleteBloodCountDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.CholesterolLevelDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.CancerMarkersDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.BloodPressureDetails", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Prescriptions", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.PatientTokens", new[] { "PatientId" });
            DropIndex("dbo.DoctorTokens", new[] { "DoctorId" });
            DropIndex("dbo.PrescriptionDetails", new[] { "PrescriptionId" });
            DropIndex("dbo.XrayDetails", new[] { "PatientId" });
            DropIndex("dbo.VitaminLevelsDetails", new[] { "PatientId" });
            DropIndex("dbo.UrineAnalysisDetails", new[] { "PatientId" });
            DropIndex("dbo.ThyroidDetails", new[] { "PatientId" });
            DropIndex("dbo.PulmonaryFunctionDetails", new[] { "PatientId" });
            DropIndex("dbo.PatientHealths", new[] { "PatientId" });
            DropIndex("dbo.OtherTestDetails", new[] { "PatientId" });
            DropIndex("dbo.MRIDetails", new[] { "PatientId" });
            DropIndex("dbo.LiverFunctionDetails", new[] { "PatientId" });
            DropIndex("dbo.KidneyFunctionDetails", new[] { "PatientId" });
            DropIndex("dbo.ImmunizationHistoryDetails", new[] { "PatientId" });
            DropIndex("dbo.HemoglobinDetails", new[] { "PatientId" });
            DropIndex("dbo.GlucoseLevelDetails", new[] { "PatientId" });
            DropIndex("dbo.ECGDetails", new[] { "PatientId" });
            DropIndex("dbo.CTScanDetails", new[] { "PatientId" });
            DropIndex("dbo.CompleteBloodCountDetails", new[] { "PatientId" });
            DropIndex("dbo.CholesterolLevelDetails", new[] { "PatientId" });
            DropIndex("dbo.CancerMarkersDetails", new[] { "PatientId" });
            DropIndex("dbo.BloodPressureDetails", new[] { "PatientId" });
            DropIndex("dbo.Prescriptions", new[] { "DoctorId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.PatientTokens");
            DropTable("dbo.DoctorTokens");
            DropTable("dbo.Assistants");
            DropTable("dbo.PrescriptionDetails");
            DropTable("dbo.XrayDetails");
            DropTable("dbo.VitaminLevelsDetails");
            DropTable("dbo.UrineAnalysisDetails");
            DropTable("dbo.ThyroidDetails");
            DropTable("dbo.PulmonaryFunctionDetails");
            DropTable("dbo.PatientHealths");
            DropTable("dbo.OtherTestDetails");
            DropTable("dbo.MRIDetails");
            DropTable("dbo.LiverFunctionDetails");
            DropTable("dbo.KidneyFunctionDetails");
            DropTable("dbo.ImmunizationHistoryDetails");
            DropTable("dbo.HemoglobinDetails");
            DropTable("dbo.GlucoseLevelDetails");
            DropTable("dbo.ECGDetails");
            DropTable("dbo.CTScanDetails");
            DropTable("dbo.CompleteBloodCountDetails");
            DropTable("dbo.CholesterolLevelDetails");
            DropTable("dbo.CancerMarkersDetails");
            DropTable("dbo.BloodPressureDetails");
            DropTable("dbo.Patients");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
