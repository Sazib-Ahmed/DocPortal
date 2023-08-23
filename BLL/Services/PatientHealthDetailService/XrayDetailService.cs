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
    public class XrayDetailService
    {
        public static List<XrayDetailDTO> GetAll()
        {
            var data = DataAccessFactory.XrayDetailData().Get();
            var mapper = MapperService<XrayDetail, XrayDetailDTO>.GetMapper();
            return mapper.Map<List<XrayDetailDTO>>(data);
        }

        public static bool Create(XrayDetailDTO obj)
        {
            var mapper = MapperService<XrayDetailDTO, XrayDetail>.GetMapper();
            var mapped = mapper.Map<XrayDetail>(obj);
            return DataAccessFactory.XrayDetailData().Create(mapped);
        }

        public static bool Update(XrayDetailDTO obj)
        {
            var mapper = MapperService<XrayDetailDTO, XrayDetail>.GetMapper();
            var mapped = mapper.Map<XrayDetail>(obj);
            return DataAccessFactory.XrayDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.XrayDetailData().Delete(id);
        }

        public static XrayDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.XrayDetailData().Get(id);
            var mapper = MapperService<XrayDetail, XrayDetailDTO>.GetMapper();
            return mapper.Map<XrayDetailDTO>(data);
        }
    }
}
