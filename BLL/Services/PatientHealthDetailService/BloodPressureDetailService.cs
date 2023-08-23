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
    public class BloodPressureDetailService
    {
        public static List<BloodPressureDetailDTO> GetAll()
        {
            var data = DataAccessFactory.BloodPressureDetailData().Get();
            var mapper = MapperService<BloodPressureDetail, BloodPressureDetailDTO>.GetMapper();
            return mapper.Map<List<BloodPressureDetailDTO>>(data);
        }

        public static bool Create(BloodPressureDetailDTO obj)
        {
            var mapper = MapperService<BloodPressureDetailDTO, BloodPressureDetail>.GetMapper();
            var mapped = mapper.Map<BloodPressureDetail>(obj);
            return DataAccessFactory.BloodPressureDetailData().Create(mapped);
        }

        public static bool Update(BloodPressureDetailDTO obj)
        {
            var mapper = MapperService<BloodPressureDetailDTO, BloodPressureDetail>.GetMapper();
            var mapped = mapper.Map<BloodPressureDetail>(obj);
            return DataAccessFactory.BloodPressureDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.BloodPressureDetailData().Delete(id);
        }

        public static BloodPressureDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.BloodPressureDetailData().Get(id);
            var mapper = MapperService<BloodPressureDetail, BloodPressureDetailDTO>.GetMapper();
            return mapper.Map<BloodPressureDetailDTO>(data);
        }
    }
}
