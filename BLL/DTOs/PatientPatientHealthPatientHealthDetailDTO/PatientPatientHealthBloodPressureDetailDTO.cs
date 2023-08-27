using BLL.DTOs.PatientHealthDetailDTO;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.PatientPatientHealthPatientHealthDetailDTO
{
    public class PatientPatientHealthBloodPressureDetailDTO : PatientDTO
    {
        public List<PatientHealthDTO> PatientHealths { get; set; }
        public List<BloodPressureDetailDTO> BloodPressureDetails { get; set; }

        public PatientPatientHealthBloodPressureDetailDTO()
        {
            PatientHealths = new List<PatientHealthDTO>();
            BloodPressureDetails = new List<BloodPressureDetailDTO>();

        }
    }
}