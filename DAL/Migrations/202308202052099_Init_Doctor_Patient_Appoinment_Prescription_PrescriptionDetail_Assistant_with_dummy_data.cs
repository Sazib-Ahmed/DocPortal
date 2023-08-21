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
                        DateOfBirth = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        Education = c.String(),
                        ExperienceYears = c.String(),
                        RegistrationNumber = c.String(),
                        Certifications = c.String(),
                        Description = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.PrescriptionDetails", "PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Prescriptions", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.PrescriptionDetails", new[] { "PrescriptionId" });
            DropIndex("dbo.Prescriptions", new[] { "DoctorId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.Assistants");
            DropTable("dbo.PrescriptionDetails");
            DropTable("dbo.Patients");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
