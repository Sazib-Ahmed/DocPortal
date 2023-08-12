namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updating_doctor_Adding_Prescription_And_PrescriptionDetail_with_dummy_data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
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
                .Index(t => t.DoctorId);
            
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
            
            AddColumn("dbo.Doctors", "Speciality", c => c.String());
            AddColumn("dbo.Doctors", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "Sex", c => c.Int(nullable: false));
            AddColumn("dbo.Doctors", "Education", c => c.String());
            AddColumn("dbo.Doctors", "ExperienceYears", c => c.String());
            AddColumn("dbo.Doctors", "RegistrationNumber", c => c.String());
            AddColumn("dbo.Doctors", "Certifications", c => c.String());
            DropColumn("dbo.Doctors", "SpecialityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "SpecialityId", c => c.Int(nullable: false));
            DropForeignKey("dbo.PrescriptionDetails", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.PrescriptionDetails", new[] { "PrescriptionId" });
            DropIndex("dbo.Prescriptions", new[] { "DoctorId" });
            DropColumn("dbo.Doctors", "Certifications");
            DropColumn("dbo.Doctors", "RegistrationNumber");
            DropColumn("dbo.Doctors", "ExperienceYears");
            DropColumn("dbo.Doctors", "Education");
            DropColumn("dbo.Doctors", "Sex");
            DropColumn("dbo.Doctors", "DateOfBirth");
            DropColumn("dbo.Doctors", "Speciality");
            DropTable("dbo.PrescriptionDetails");
            DropTable("dbo.Prescriptions");
        }
    }
}
