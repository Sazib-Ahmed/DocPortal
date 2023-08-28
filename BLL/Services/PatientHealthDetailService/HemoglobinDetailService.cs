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
    public class HemoglobinDetailService
    {
        public static List<HemoglobinDetailDTO> GetAll()
        {
            var data = DataAccessFactory.HemoglobinDetailData().Get();
            var mapper = MapperService<HemoglobinDetail, HemoglobinDetailDTO>.GetMapper();
            return mapper.Map<List<HemoglobinDetailDTO>>(data);
        }
        public static bool Create(HemoglobinDetailDTO obj)
        {
            var mapper = MapperService<HemoglobinDetailDTO, HemoglobinDetail>.GetMapper();
            var mapped = mapper.Map<HemoglobinDetail>(obj);
            return DataAccessFactory.HemoglobinDetailData().Create(mapped);
        }
        public static bool Update(HemoglobinDetailDTO obj)
        {
            var mapper = MapperService<HemoglobinDetailDTO, HemoglobinDetail>.GetMapper();
            var mapped = mapper.Map<HemoglobinDetail>(obj);
            return DataAccessFactory.HemoglobinDetailData().Update(mapped);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.HemoglobinDetailData().Delete(id);
        }
        public static HemoglobinDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.HemoglobinDetailData().Get(id);
            var mapper = MapperService<HemoglobinDetail, HemoglobinDetailDTO>.GetMapper();
            return mapper.Map<HemoglobinDetailDTO>(data);
        }
        public static List<HemoglobinDetailDTO> GetHemoglobinDetailByPatientId(int patientId)
        {
            var hemoglobinDetailData = DataAccessFactory.HemoglobinDetailData().Get();
            var data = (from h in hemoglobinDetailData
                                               where h.PatientId == patientId
                                                                      select h).ToList();
            var mapper = MapperService<HemoglobinDetail, HemoglobinDetailDTO>.GetMapper();
            return mapper.Map<List<HemoglobinDetailDTO>>(data);
        }
    }
}
