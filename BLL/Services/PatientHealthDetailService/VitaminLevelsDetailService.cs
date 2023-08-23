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
    public class VitaminLevelsDetailService
    {
        public static List<VitaminLevelsDetailDTO> GetAll()
        {
            var data = DataAccessFactory.VitaminLevelsDetailData().Get();
            var mapper = MapperService<VitaminLevelsDetail, VitaminLevelsDetailDTO>.GetMapper();
            return mapper.Map<List<VitaminLevelsDetailDTO>>(data);
        }

        public static bool Create(VitaminLevelsDetailDTO obj)
        {
            var mapper = MapperService<VitaminLevelsDetailDTO, VitaminLevelsDetail>.GetMapper();
            var mapped = mapper.Map<VitaminLevelsDetail>(obj);
            return DataAccessFactory.VitaminLevelsDetailData().Create(mapped);
        }

        public static bool Update(VitaminLevelsDetailDTO obj)
        {
            var mapper = MapperService<VitaminLevelsDetailDTO, VitaminLevelsDetail>.GetMapper();
            var mapped = mapper.Map<VitaminLevelsDetail>(obj);
            return DataAccessFactory.VitaminLevelsDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.VitaminLevelsDetailData().Delete(id);
        }

        public static VitaminLevelsDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.VitaminLevelsDetailData().Get(id);
            var mapper = MapperService<VitaminLevelsDetail, VitaminLevelsDetailDTO>.GetMapper();
            return mapper.Map<VitaminLevelsDetailDTO>(data);
        }
    }
}
