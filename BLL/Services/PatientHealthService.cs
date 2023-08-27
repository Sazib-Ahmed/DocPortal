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
using DAL.EF.Models.PatientHealthDetail;
using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;

namespace BLL.Services
{
    public class PatientHealthService
    {
        ////GetALL() , Create() , Update() , Delete() , GetById() , GetByPatientHealthId()
        
        public static List<PatientHealthDTO> GetAll()
        {
            var data = DataAccessFactory.PatientHealthData().Get();
            var mapper = PatientHealthMapperService<PatientHealth, PatientHealthDTO>.GetMapper();
            return mapper.Map<List<PatientHealthDTO>>(data);
        }

        public static bool Create(PatientHealthDTO obj)
        {
            var mapper = PatientHealthMapperService<PatientHealthDTO, PatientHealth>.GetMapper();
            var mapped = mapper.Map<PatientHealth>(obj);
            return DataAccessFactory.PatientHealthData().Create(mapped);
        }


        public static bool Delete(int patientHealthId)
        {
            return DataAccessFactory.PatientHealthData().Delete(patientHealthId);
        }
        public static bool Update(PatientHealthDTO obj)
        {
            var mapper = PatientHealthMapperService<PatientHealthDTO, PatientHealth>.GetMapper();
            var mapped = mapper.Map<PatientHealth>(obj);
            return DataAccessFactory.PatientHealthData().Update(mapped);
        }

        public static PatientHealthDTO GetById(int patientHealthId)
        {
            var data = DataAccessFactory.PatientHealthData().Get(patientHealthId);
            var mapper = PatientHealthMapperService<PatientHealth, PatientHealthDTO>.GetMapper();
            return mapper.Map<PatientHealthDTO>(data);
        }

        public static List<PatientHealthDTO> GetByPatientId(int patientId)
        {
            var data = (from h in DataAccessFactory.PatientHealthData().Get()
                        where h.PatientId == patientId
                        select h).ToList();
            var mapper = PatientHealthMapperService<PatientHealth, PatientHealthDTO>.GetMapper();
            return mapper.Map<List<PatientHealthDTO>>(data);
        }


        // SHORT Version by using custom automapper for patient health detail
        public static PatientHealthPatientHealthDetailDTO GetPatientHealthDetailByPatientId(int patientId)
        {
            try
            {
                var data = (from h in DataAccessFactory.PatientHealthData().Get()
                            where h.PatientId == patientId
                            select h).FirstOrDefault();

                if (data == null) { return null; }

                // custom mapper for patient health detail
                var map = PatientHealthDetailMapperService.GetDetailMapper(); 
                var result = map.Map<PatientHealthPatientHealthDetailDTO>(data);

                return result;
            }
            catch (Exception ex)
            {
                // log the exception
                throw new Exception("Error occurred while fetching patient health detail by patient id.", ex);
            }
        }


        // LONG Version without custom automapper for patient health detail

        //public static PatientHealthPatientHealthDetailDTO GetPatientHealthDetailByPatientId(int patientId)
        //{
        //    try
        //    {
        //        var data = (from h in DataAccessFactory.PatientHealthData().Get()
        //                    where h.PatientId == patientId
        //                    select h).FirstOrDefault();

        //        if(data == null){return null;}

        //        var config = new MapperConfiguration(cfg =>
        //        {
        //            cfg.CreateMap<PatientHealth, PatientHealthPatientHealthDetailDTO>();
        //            cfg.CreateMap<BloodPressureDetail, BloodPressureDetailDTO>();
        //            cfg.CreateMap<HemoglobinDetail, HemoglobinDetailDTO>();
        //            cfg.CreateMap<XrayDetail, XrayDetailDTO>();
        //            cfg.CreateMap<MRIDetail, MRIDetailDTO>();
        //            cfg.CreateMap<CTScanDetail, CTScanDetailDTO>();
        //            cfg.CreateMap<GlucoseLevelDetail, GlucoseLevelDetailDTO>();
        //            cfg.CreateMap<CholesterolLevelDetail, CholesterolLevelDetailDTO>();
        //            cfg.CreateMap<ThyroidDetail, ThyroidDetailDTO>();
        //            cfg.CreateMap<LiverFunctionDetail, LiverFunctionDetailDTO>();
        //            cfg.CreateMap<KidneyFunctionDetail, KidneyFunctionDetailDTO>();
        //            cfg.CreateMap<CompleteBloodCountDetail, CompleteBloodCountDetailDTO>();
        //            cfg.CreateMap<UrineAnalysisDetail, UrineAnalysisDetailDTO>();
        //            cfg.CreateMap<ECGDetail, ECGDetailDTO>();
        //            cfg.CreateMap<PulmonaryFunctionDetail, PulmonaryFunctionDetailDTO>();
        //            cfg.CreateMap<VitaminLevelsDetail, VitaminLevelsDetailDTO>();
        //            cfg.CreateMap<CancerMarkersDetail, CancerMarkersDetailDTO>();
        //            cfg.CreateMap<ImmunizationHistoryDetail, ImmunizationHistoryDetailDTO>();
        //            cfg.CreateMap<OtherTestDetail, OtherTestDetailDTO>();

        //        });

        //        var map = new Mapper(config);
        //        var result = map.Map<PatientHealthPatientHealthDetailDTO>(data);

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        // log the exception
        //        throw new Exception("Error occurred while fetching patient health detail by patient id.", ex);
        //    }
        //}


        public static PatientHealthPatientHealthDetailDTO GetPatientHealthDetailByPatientHealthId(int patientHealthId)
        {
            var data = DataAccessFactory.PatientHealthData().Get(patientHealthId);

            // custom mapper for patient health detail
            var map = PatientHealthDetailMapperService.GetDetailMapper();
            var result = map.Map<PatientHealthPatientHealthDetailDTO>(data);

            return result;
        }





        



    }
}
