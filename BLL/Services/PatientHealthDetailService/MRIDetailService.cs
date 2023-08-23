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
    public class MRIDetailService
    {
        public static List<MRIDetailDTO> GetAll()
        {
            var data = DataAccessFactory.MRIDetailData().Get();
            var mapper = MapperService<MRIDetail, MRIDetailDTO>.GetMapper();
            return mapper.Map<List<MRIDetailDTO>>(data);
        }

        public static bool Create(MRIDetailDTO obj)
        {
            var mapper = MapperService<MRIDetailDTO, MRIDetail>.GetMapper();
            var mapped = mapper.Map<MRIDetail>(obj);
            return DataAccessFactory.MRIDetailData().Create(mapped);
        }

        public static bool Update(MRIDetailDTO obj)
        {
            var mapper = MapperService<MRIDetailDTO, MRIDetail>.GetMapper();
            var mapped = mapper.Map<MRIDetail>(obj);
            return DataAccessFactory.MRIDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.MRIDetailData().Delete(id);
        }

        public static MRIDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.MRIDetailData().Get(id);
            var mapper = MapperService<MRIDetail, MRIDetailDTO>.GetMapper();
            return mapper.Map<MRIDetailDTO>(data);
        }
    }
}
