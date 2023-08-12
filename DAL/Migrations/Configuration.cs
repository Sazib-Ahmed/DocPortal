namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static DAL.EF.Models.Doctor;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.DocPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.DocPortalContext context)
        {
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                context.Doctors.AddOrUpdate(
                    new EF.Models.Doctor
                    {
                        Name = "Doctor " + i,
                        Speciality = "Speciality " + random.Next(1, 11),
                        Image = "doctor" + i + ".jpg",
                        Phone = "123-456-7890",
                        Password = "password" + i,
                        Email = "doctor" + i + "@example.com",
                        Address = "123 Street, City",
                        DateOfBirth = DateTime.Now.AddYears(-30).AddDays(random.Next(-365, 365)),
                        Sex = (Gender)random.Next(0, Enum.GetValues(typeof(Gender)).Length),
                        Education = "Education for Doctor " + i,
                        ExperienceYears = random.Next(1, 31).ToString(),
                        RegistrationNumber = "Reg" + i,
                        Certifications = "Certifications for Doctor " + i,
                        Description = "Description for Doctor " + i,
                        Prescription = new List<Prescription>()
                    }
                );
                context.SaveChanges(); // Save the doctor to get its Id



                context.Prescriptions.AddOrUpdate(
                    new EF.Models.Prescription
                    {
                        DoctorId = 1,
                        PatientId = i,
                        Date = DateTime.Now.AddDays(random.Next(0, 8) * -1),
                        ChiefComplaint = "Chief Complain " + i,
                        PhysicalExam = "Physical Examination " + i,
                        Investigation = "Investigation " + i,
                        Diagnosis = "Diagnosis " + i,
                        NextAppointment = DateTime.Now.AddDays(random.Next(0, 8) * -1),

                        // Add PrescriptionDetails
                        PrescriptionDetail = new List<EF.Models.PrescriptionDetail>
                        {
                            new EF.Models.PrescriptionDetail
                            {
                                Medication = "Medication " + i,
                                Dosage = "Dosage " + i,
                                Instructions = "Instructions " + i,
                            },
                            // Add more PrescriptionDetail items if needed
                        }
                    }
                );
                context.SaveChanges();

                //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method
                //  to avoid creating duplicate seed data.
            }
        }
    }
}
