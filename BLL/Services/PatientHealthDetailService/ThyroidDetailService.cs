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
    public class ThyroidDetailService
    {
        public static List<ThyroidDetailDTO> GetAll()
        {
            var data = DataAccessFactory.ThyroidDetailData().Get();
            var mapper = MapperService<ThyroidDetail, ThyroidDetailDTO>.GetMapper();
            return mapper.Map<List<ThyroidDetailDTO>>(data);
        }

        public static bool Create(ThyroidDetailDTO obj)
        {
            var mapper = MapperService<ThyroidDetailDTO, ThyroidDetail>.GetMapper();
            var mapped = mapper.Map<ThyroidDetail>(obj);
            return DataAccessFactory.ThyroidDetailData().Create(mapped);
        }

        public static bool Update(ThyroidDetailDTO obj)
        {
            var mapper = MapperService<ThyroidDetailDTO, ThyroidDetail>.GetMapper();
            var mapped = mapper.Map<ThyroidDetail>(obj);
            return DataAccessFactory.ThyroidDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ThyroidDetailData().Delete(id);
        }

        public static ThyroidDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.ThyroidDetailData().Get(id);
            var mapper = MapperService<ThyroidDetail, ThyroidDetailDTO>.GetMapper();
            return mapper.Map<ThyroidDetailDTO>(data);
        }
    }
}
