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
    public class UrineAnalysisDetailService
    {
        public static List<UrineAnalysisDetailDTO> GetAll()
        {
            var data = DataAccessFactory.UrineAnalysisDetailData().Get();
            var mapper = MapperService<UrineAnalysisDetail, UrineAnalysisDetailDTO>.GetMapper();
            return mapper.Map<List<UrineAnalysisDetailDTO>>(data);
        }

        public static bool Create(UrineAnalysisDetailDTO obj)
        {
            var mapper = MapperService<UrineAnalysisDetailDTO, UrineAnalysisDetail>.GetMapper();
            var mapped = mapper.Map<UrineAnalysisDetail>(obj);
            return DataAccessFactory.UrineAnalysisDetailData().Create(mapped);
        }

        public static bool Update(UrineAnalysisDetailDTO obj)
        {
            var mapper = MapperService<UrineAnalysisDetailDTO, UrineAnalysisDetail>.GetMapper();
            var mapped = mapper.Map<UrineAnalysisDetail>(obj);
            return DataAccessFactory.UrineAnalysisDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.UrineAnalysisDetailData().Delete(id);
        }

        public static UrineAnalysisDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.UrineAnalysisDetailData().Get(id);
            var mapper = MapperService<UrineAnalysisDetail, UrineAnalysisDetailDTO>.GetMapper();
            return mapper.Map<UrineAnalysisDetailDTO>(data);
        }
    }
}
