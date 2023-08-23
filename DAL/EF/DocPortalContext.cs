using DAL.EF.Models;
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
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<PatientToken> PatientTokens { get; set; }
    }
}
