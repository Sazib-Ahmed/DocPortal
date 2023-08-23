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
    public class PulmonaryFunctionDetailService
    {
        public static List<PulmonaryFunctionDetailDTO> GetAll()
        {
            var data = DataAccessFactory.PulmonaryFunctionDetailData().Get();
            var mapper = MapperService<PulmonaryFunctionDetail, PulmonaryFunctionDetailDTO>.GetMapper();
            return mapper.Map<List<PulmonaryFunctionDetailDTO>>(data);
        }
        public static bool Create(PulmonaryFunctionDetailDTO obj)
        {
            var mapper = MapperService<PulmonaryFunctionDetailDTO, PulmonaryFunctionDetail>.GetMapper();
            var mapped = mapper.Map<PulmonaryFunctionDetail>(obj);
            return DataAccessFactory.PulmonaryFunctionDetailData().Create(mapped);
        }
        public static bool Update(PulmonaryFunctionDetailDTO obj)
        {
            var mapper = MapperService<PulmonaryFunctionDetailDTO, PulmonaryFunctionDetail>.GetMapper();
            var mapped = mapper.Map<PulmonaryFunctionDetail>(obj);
            return DataAccessFactory.PulmonaryFunctionDetailData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PulmonaryFunctionDetailData().Delete(id);
        }
        public static PulmonaryFunctionDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.PulmonaryFunctionDetailData().Get(id);
            var mapper = MapperService<PulmonaryFunctionDetail, PulmonaryFunctionDetailDTO>.GetMapper();
            return mapper.Map<PulmonaryFunctionDetailDTO>(data);
        }
    }
}
