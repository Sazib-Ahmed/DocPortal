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
    public class OtherTestDetailService
    {
        public static List<OtherTestDetailDTO> GetAll()
        {
            var data = DataAccessFactory.OtherTestDetailData().Get();
            var mapper = MapperService<OtherTestDetail, OtherTestDetailDTO>.GetMapper();
            return mapper.Map<List<OtherTestDetailDTO>>(data);
        }

        public static bool Create(OtherTestDetailDTO obj)
        {
            var mapper = MapperService<OtherTestDetailDTO, OtherTestDetail>.GetMapper();
            var mapped = mapper.Map<OtherTestDetail>(obj);
            return DataAccessFactory.OtherTestDetailData().Create(mapped);
        }

        public static bool Update(OtherTestDetailDTO obj)
        {
            var mapper = MapperService<OtherTestDetailDTO, OtherTestDetail>.GetMapper();
            var mapped = mapper.Map<OtherTestDetail>(obj);
            return DataAccessFactory.OtherTestDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.OtherTestDetailData().Delete(id);
        }

        public static OtherTestDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.OtherTestDetailData().Get(id);
            var mapper = MapperService<OtherTestDetail, OtherTestDetailDTO>.GetMapper();
            return mapper.Map<OtherTestDetailDTO>(data);
        }
    }
}
