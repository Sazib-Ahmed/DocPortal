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
    public class LiverFunctionDetailService
    {
        public static List<LiverFunctionDetailDTO> GetAll()
        {
            var data = DataAccessFactory.LiverFunctionDetailData().Get();
            var mapper = MapperService<LiverFunctionDetail, LiverFunctionDetailDTO>.GetMapper();
            return mapper.Map<List<LiverFunctionDetailDTO>>(data);
        }

        public static bool Create(LiverFunctionDetailDTO obj)
        {
            var mapper = MapperService<LiverFunctionDetailDTO, LiverFunctionDetail>.GetMapper();
            var mapped = mapper.Map<LiverFunctionDetail>(obj);
            return DataAccessFactory.LiverFunctionDetailData().Create(mapped);
        }

        public static bool Update(LiverFunctionDetailDTO obj)
        {
            var mapper = MapperService<LiverFunctionDetailDTO, LiverFunctionDetail>.GetMapper();
            var mapped = mapper.Map<LiverFunctionDetail>(obj);
            return DataAccessFactory.LiverFunctionDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.LiverFunctionDetailData().Delete(id);
        }

        public static LiverFunctionDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.LiverFunctionDetailData().Get(id);
            var mapper = MapperService<LiverFunctionDetail, LiverFunctionDetailDTO>.GetMapper();
            return mapper.Map<LiverFunctionDetailDTO>(data);
        }
        public static LiverFunctionDetailDTO GetLiverFunctionDetailByPatientId(int patientId)
        {
            var data = DataAccessFactory.LiverFunctionDetailData().Get().Where(x => x.PatientId == patientId).FirstOrDefault();
            var mapper = MapperService<LiverFunctionDetail, LiverFunctionDetailDTO>.GetMapper();
            return mapper.Map<LiverFunctionDetailDTO>(data);
        }

    }
}
