namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_Health_Detail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodPressureDetails",
                c => new
                    {
                        BloodPressureDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        SystolicPressure = c.Int(),
                        DiastolicPressure = c.Int(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.BloodPressureDetailId)
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
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
                "dbo.CancerMarkersDetails",
                c => new
                    {
                        CancerMarkersDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.CholesterolLevelDetails",
                c => new
                    {
                        CholesterolLevelDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
                        TotalCholesterol = c.Double(nullable: false),
                        LDLCholesterol = c.Double(nullable: false),
                        HDLCholesterol = c.Double(nullable: false),
                        Triglycerides = c.Double(nullable: false),
                        RecordedAt = c.DateTime(nullable: false),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CholesterolLevelDetailId)
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.CompleteBloodCountDetails",
                c => new
                    {
                        CompleteBloodCountDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.CTScanDetails",
                c => new
                    {
                        CTScanDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        ScanLocation = c.String(),
                        ScanData = c.String(),
                        ScanResult = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CTScanDetailId)
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.ECGDetails",
                c => new
                    {
                        ECGDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        TestLocation = c.String(),
                        TestResult = c.String(),
                        ECGData = c.String(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ECGDetailId)
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.GlucoseLevelDetails",
                c => new
                    {
                        GlucoseLevelDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
                        RecordedAt = c.DateTime(),
                        GlucoseLevel = c.Double(),
                        PerformedBy = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.GlucoseLevelDetailId)
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.HemoglobinDetails",
                c => new
                    {
                        HemoglobinDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.ImmunizationHistoryDetails",
                c => new
                    {
                        ImmunizationHistoryDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.KidneyFunctionDetails",
                c => new
                    {
                        KidneyFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.LiverFunctionDetails",
                c => new
                    {
                        LiverFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.MRIDetails",
                c => new
                    {
                        MRIDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.OtherTestDetails",
                c => new
                    {
                        OtherTestDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.PulmonaryFunctionDetails",
                c => new
                    {
                        PulmonaryFunctionDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.ThyroidDetails",
                c => new
                    {
                        ThyroidDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.UrineAnalysisDetails",
                c => new
                    {
                        UrineAnalysisDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.VitaminLevelsDetails",
                c => new
                    {
                        VitaminLevelsDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
            CreateTable(
                "dbo.XrayDetails",
                c => new
                    {
                        XrayDetailId = c.Int(nullable: false, identity: true),
                        PatientHealthId = c.Int(nullable: false),
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
                .ForeignKey("dbo.PatientHealths", t => t.PatientHealthId, cascadeDelete: true)
                .Index(t => t.PatientHealthId);
            
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
            DropForeignKey("dbo.BloodPressureDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.XrayDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.VitaminLevelsDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.UrineAnalysisDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.ThyroidDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.PulmonaryFunctionDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.PatientHealths", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.OtherTestDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.MRIDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.LiverFunctionDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.KidneyFunctionDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.ImmunizationHistoryDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.HemoglobinDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.GlucoseLevelDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.ECGDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.CTScanDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.CompleteBloodCountDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.CholesterolLevelDetails", "PatientHealthId", "dbo.PatientHealths");
            DropForeignKey("dbo.CancerMarkersDetails", "PatientHealthId", "dbo.PatientHealths");
            DropIndex("dbo.PatientTokens", new[] { "PatientId" });
            DropIndex("dbo.XrayDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.VitaminLevelsDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.UrineAnalysisDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.ThyroidDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.PulmonaryFunctionDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.OtherTestDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.MRIDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.LiverFunctionDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.KidneyFunctionDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.ImmunizationHistoryDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.HemoglobinDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.GlucoseLevelDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.ECGDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.CTScanDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.CompleteBloodCountDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.CholesterolLevelDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.CancerMarkersDetails", new[] { "PatientHealthId" });
            DropIndex("dbo.PatientHealths", new[] { "PatientId" });
            DropIndex("dbo.BloodPressureDetails", new[] { "PatientHealthId" });
            DropTable("dbo.PatientTokens");
            DropTable("dbo.XrayDetails");
            DropTable("dbo.VitaminLevelsDetails");
            DropTable("dbo.UrineAnalysisDetails");
            DropTable("dbo.ThyroidDetails");
            DropTable("dbo.PulmonaryFunctionDetails");
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
            DropTable("dbo.PatientHealths");
            DropTable("dbo.BloodPressureDetails");
        }
    }
}
