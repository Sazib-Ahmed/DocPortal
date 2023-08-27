using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.PatientHealthDetailDTO;
using DAL.Repo.PatientHealthDetailRepo;
using DAL.EF.Models.PatientHealthDetail;
using DAL;
using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;

namespace BLL.Services.PatientHealthDetailService
{
    public class BloodPressureDetailService
    {
        public static List<BloodPressureDetailDTO> GetAll()
        {
            var data = DataAccessFactory.BloodPressureDetailData().Get();
            var mapper = MapperService<BloodPressureDetail, BloodPressureDetailDTO>.GetMapper();
            return mapper.Map<List<BloodPressureDetailDTO>>(data);
        }

        public static bool Create(BloodPressureDetailDTO obj)
        {
            var mapper = MapperService<BloodPressureDetailDTO, BloodPressureDetail>.GetMapper();
            var mapped = mapper.Map<BloodPressureDetail>(obj);
            return DataAccessFactory.BloodPressureDetailData().Create(mapped);
        }

        public static bool Update(BloodPressureDetailDTO obj)
        {
            var mapper = MapperService<BloodPressureDetailDTO, BloodPressureDetail>.GetMapper();
            var mapped = mapper.Map<BloodPressureDetail>(obj);
            return DataAccessFactory.BloodPressureDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.BloodPressureDetailData().Delete(id);
        }

        public static BloodPressureDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.BloodPressureDetailData().Get(id);
            var mapper = MapperService<BloodPressureDetail, BloodPressureDetailDTO>.GetMapper();
            return mapper.Map<BloodPressureDetailDTO>(data);
        }

        // for blood pressure detail

        public static BloodPressureDetailDTO GetBloodPressureDetailByPatientHealthId(int patientHealthId)
        {

            var bloodPressureDetailData = BloodPressureDetailService.GetAll();

            var data = (from bp in bloodPressureDetailData
                        where bp.PatientHealthId == patientHealthId
                        select bp).ToList();

            if (data != null)
            {
                var mapper = MapperService<BloodPressureDetail, BloodPressureDetailDTO>.GetMapper();
                return mapper.Map<BloodPressureDetailDTO>(data);
            }
            else
            {
                throw new Exception("Patient health record not found.");
            }
        }



        public static PatientHealthPatientHealthDetailDTO GetBloodPressureDetailByPatientId(int patientId)
        {
            var data = (from h in DataAccessFactory.PatientHealthData().Get()
                        where h.PatientId == patientId
                        select h).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientHealth, PatientHealthPatientHealthDetailDTO>();
                cfg.CreateMap<BloodPressureDetail, BloodPressureDetailDTO>();

            });

            var map = new Mapper(config);
            var result = map.Map<PatientHealthPatientHealthDetailDTO>(data);

            return result;
        }

    }
}
