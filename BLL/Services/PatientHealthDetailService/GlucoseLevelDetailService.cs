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
    public class GlucoseLevelDetailService
    {
        public static List<GlucoseLevelDetailDTO> GetAll()
        {
            var data = DataAccessFactory.GlucoseLevelDetailData().Get();
            var mapper = MapperService<GlucoseLevelDetail, GlucoseLevelDetailDTO>.GetMapper();
            return mapper.Map<List<GlucoseLevelDetailDTO>>(data);
        }

        public static bool Create(GlucoseLevelDetailDTO obj)
        {
            var mapper = MapperService<GlucoseLevelDetailDTO, GlucoseLevelDetail>.GetMapper();
            var mapped = mapper.Map<GlucoseLevelDetail>(obj);
            return DataAccessFactory.GlucoseLevelDetailData().Create(mapped);
        }

        public static bool Update(GlucoseLevelDetailDTO obj)
        {
            var mapper = MapperService<GlucoseLevelDetailDTO, GlucoseLevelDetail>.GetMapper();
            var mapped = mapper.Map<GlucoseLevelDetail>(obj);
            return DataAccessFactory.GlucoseLevelDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.GlucoseLevelDetailData().Delete(id);
        }

        public static GlucoseLevelDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.GlucoseLevelDetailData().Get(id);
            var mapper = MapperService<GlucoseLevelDetail, GlucoseLevelDetailDTO>.GetMapper();
            return mapper.Map<GlucoseLevelDetailDTO>(data);
        }
    }
}
