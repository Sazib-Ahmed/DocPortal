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
    public class ImmunizationHistoryDetailService
    {
        public static List<ImmunizationHistoryDetailDTO> GetAll()
        {
            var data = DataAccessFactory.ImmunizationHistoryDetailData().Get();
            var mapper = MapperService<ImmunizationHistoryDetail, ImmunizationHistoryDetailDTO>.GetMapper();
            return mapper.Map<List<ImmunizationHistoryDetailDTO>>(data);
        }

        public static bool Create(ImmunizationHistoryDetailDTO obj)
        {
            var mapper = MapperService<ImmunizationHistoryDetailDTO, ImmunizationHistoryDetail>.GetMapper();
            var mapped = mapper.Map<ImmunizationHistoryDetail>(obj);
            return DataAccessFactory.ImmunizationHistoryDetailData().Create(mapped);
        }

        public static bool Update(ImmunizationHistoryDetailDTO obj)
        {
            var mapper = MapperService<ImmunizationHistoryDetailDTO, ImmunizationHistoryDetail>.GetMapper();
            var mapped = mapper.Map<ImmunizationHistoryDetail>(obj);
            return DataAccessFactory.ImmunizationHistoryDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ImmunizationHistoryDetailData().Delete(id);
        }

        public static ImmunizationHistoryDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.ImmunizationHistoryDetailData().Get(id);
            var mapper = MapperService<ImmunizationHistoryDetail, ImmunizationHistoryDetailDTO>.GetMapper();
            return mapper.Map<ImmunizationHistoryDetailDTO>(data);
        }
    }
}
