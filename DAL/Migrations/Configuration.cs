namespace DAL.Migrations
{
    using DAL.EF.Models;
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
        }
    }
}
