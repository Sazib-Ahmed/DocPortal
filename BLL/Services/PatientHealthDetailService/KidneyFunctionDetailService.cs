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
    public class KidneyFunctionDetailService
    {
        public static List<KidneyFunctionDetailDTO> GetAll()
        {
            var data = DataAccessFactory.KidneyFunctionDetailData().Get();
            var mapper = MapperService<KidneyFunctionDetail, KidneyFunctionDetailDTO>.GetMapper();
            return mapper.Map<List<KidneyFunctionDetailDTO>>(data);
        }
        public static bool Create(KidneyFunctionDetailDTO obj)
        {
            var mapper = MapperService<KidneyFunctionDetailDTO, KidneyFunctionDetail>.GetMapper();
            var mapped = mapper.Map<KidneyFunctionDetail>(obj);
            return DataAccessFactory.KidneyFunctionDetailData().Create(mapped);
        }
        public static bool Update(KidneyFunctionDetailDTO obj)
        {
            var mapper = MapperService<KidneyFunctionDetailDTO, KidneyFunctionDetail>.GetMapper();
            var mapped = mapper.Map<KidneyFunctionDetail>(obj);
            return DataAccessFactory.KidneyFunctionDetailData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.KidneyFunctionDetailData().Delete(id);
        }
        public static KidneyFunctionDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.KidneyFunctionDetailData().Get(id);
            var mapper = MapperService<KidneyFunctionDetail, KidneyFunctionDetailDTO>.GetMapper();
            return mapper.Map<KidneyFunctionDetailDTO>(data);
        }
        public static List<KidneyFunctionDetailDTO> GetKidneyFunctionDetailByPatientId(int patientId)
        {
            var kidneyFunctionDetailData = DataAccessFactory.KidneyFunctionDetailData().Get();
            var data = (from kf in kidneyFunctionDetailData
                                               where kf.PatientId == patientId
                                                                      select kf).ToList();
            var mapper = MapperService<KidneyFunctionDetail, KidneyFunctionDetailDTO>.GetMapper();
            return mapper.Map<List<KidneyFunctionDetailDTO>>(data);
        }
    }
}
