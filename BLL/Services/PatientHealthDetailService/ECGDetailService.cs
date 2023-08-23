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
    public class ECGDetailService
    {
        public static List<ECGDetailDTO> GetAll()
        {
            var data = DataAccessFactory.ECGDetailData().Get();
            var mapper = MapperService<ECGDetail, ECGDetailDTO>.GetMapper();
            return mapper.Map<List<ECGDetailDTO>>(data);
        }

        public static bool Create(ECGDetailDTO obj)
        {
            var mapper = MapperService<ECGDetailDTO, ECGDetail>.GetMapper();
            var mapped = mapper.Map<ECGDetail>(obj);
            return DataAccessFactory.ECGDetailData().Create(mapped);
        }

        public static bool Update(ECGDetailDTO obj)
        {
            var mapper = MapperService<ECGDetailDTO, ECGDetail>.GetMapper();
            var mapped = mapper.Map<ECGDetail>(obj);
            return DataAccessFactory.ECGDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ECGDetailData().Delete(id);
        }

        public static ECGDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.ECGDetailData().Get(id);
            var mapper = MapperService<ECGDetail, ECGDetailDTO>.GetMapper();
            return mapper.Map<ECGDetailDTO>(data);
        }
    }
}
