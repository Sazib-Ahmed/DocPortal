using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using DAL.Repo;
using DAL.EF.Models;
using DAL;
using AutoMapper;

namespace BLL.Services
{
    public class PatientHealthService
    {
        ////GetALL() , Create() , Update() , Delete() , GetById() , GetByPatientHealthId()
        
        public static List<PatientHealthDTO> GetAll()
        {
            var data = DataAccessFactory.PatientHealthData().Get();
            var mapper = MapperService<PatientHealth, PatientHealthDTO>.GetMapper();
            return mapper.Map<List<PatientHealthDTO>>(data);
        }

        public static bool Create(PatientHealthDTO obj)
        {
            var mapper = MapperService<PatientHealthDTO, PatientHealth>.GetMapper();
            var mapped = mapper.Map<PatientHealth>(obj);
            return DataAccessFactory.PatientHealthData().Create(mapped);
        }


        public static bool Delete(int patientHealthId)
        {
            return DataAccessFactory.PatientHealthData().Delete(patientHealthId);
        }
        public static bool Update(PatientHealthDTO obj)
        {
            var mapper = MapperService<PatientHealthDTO, PatientHealth>.GetMapper();
            var mapped = mapper.Map<PatientHealth>(obj);
            return DataAccessFactory.PatientHealthData().Update(mapped);
        }

        public static PatientHealthDTO GetById(int patientHealthId)
        {
            var data = DataAccessFactory.PatientHealthData().Get(patientHealthId);
            var mapper = MapperService<PatientHealth, PatientHealthDTO>.GetMapper();
            return mapper.Map<PatientHealthDTO>(data);
        }


    }
}
