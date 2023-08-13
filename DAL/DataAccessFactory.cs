using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repo;
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
        public static IRepo<Prescription, int, bool> PrescriptionData()
        {
            return new PrescriptionRepo();
        }
        public static IRepo<PrescriptionDetail, int, bool> PrescriptionDetailData()
        {
            return new PrescriptionDetailRepo();
        }

        public static IRepo<Patient, int, bool> PatientData()
        {
            return new PatientRepo();
        }

        public static IRepo<Appointment, int, bool> AppointmentData()
        {
            return new AppointmentRepo();
        }
    }
}


