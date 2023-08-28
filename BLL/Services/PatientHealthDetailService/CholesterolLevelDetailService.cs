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
    public class CholesterolLevelDetailService
    {
        public static List<CholesterolLevelDetailDTO> GetAll()
        {
            var data = DataAccessFactory.CholesterolLevelDetailData().Get();
            var mapper = MapperService<CholesterolLevelDetail, CholesterolLevelDetailDTO>.GetMapper();
            return mapper.Map<List<CholesterolLevelDetailDTO>>(data);
        }

        public static bool Create(CholesterolLevelDetailDTO obj)
        {
            var mapper = MapperService<CholesterolLevelDetailDTO, CholesterolLevelDetail>.GetMapper();
            var mapped = mapper.Map<CholesterolLevelDetail>(obj);
            return DataAccessFactory.CholesterolLevelDetailData().Create(mapped);
        }

        public static bool Update(CholesterolLevelDetailDTO obj)
        {
            var mapper = MapperService<CholesterolLevelDetailDTO, CholesterolLevelDetail>.GetMapper();
            var mapped = mapper.Map<CholesterolLevelDetail>(obj);
            return DataAccessFactory.CholesterolLevelDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CholesterolLevelDetailData().Delete(id);
        }

        public static CholesterolLevelDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.CholesterolLevelDetailData().Get(id);
            var mapper = MapperService<CholesterolLevelDetail, CholesterolLevelDetailDTO>.GetMapper();
            return mapper.Map<CholesterolLevelDetailDTO>(data);
        }

        public static List<CholesterolLevelDetailDTO> GetCholesterolLevelDetailByPatientId(int patientId)
        {

            var cholesterolLevelDetailData = DataAccessFactory.CholesterolLevelDetailData().Get();

            var data = (from cl in cholesterolLevelDetailData
                                               where cl.PatientId == patientId
                                                                      select cl).ToList();

            var mapper = MapperService<CholesterolLevelDetail, CholesterolLevelDetailDTO>.GetMapper();
            return mapper.Map<List<CholesterolLevelDetailDTO>>(data);
        }
    }
}
