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
    public class CompleteBloodCountDetailService
    {
        public static List<CompleteBloodCountDetailDTO> GetAll()
        {
            var data = DataAccessFactory.CompleteBloodCountDetailData().Get();
            var mapper = MapperService<CompleteBloodCountDetail, CompleteBloodCountDetailDTO>.GetMapper();
            return mapper.Map<List<CompleteBloodCountDetailDTO>>(data);
        }

        public static bool Create(CompleteBloodCountDetailDTO obj)
        {
            var mapper = MapperService<CompleteBloodCountDetailDTO, CompleteBloodCountDetail>.GetMapper();
            var mapped = mapper.Map<CompleteBloodCountDetail>(obj);
            return DataAccessFactory.CompleteBloodCountDetailData().Create(mapped);
        }

        public static bool Update(CompleteBloodCountDetailDTO obj)
        {
            var mapper = MapperService<CompleteBloodCountDetailDTO, CompleteBloodCountDetail>.GetMapper();
            var mapped = mapper.Map<CompleteBloodCountDetail>(obj);
            return DataAccessFactory.CompleteBloodCountDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CompleteBloodCountDetailData().Delete(id);
        }

        public static CompleteBloodCountDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.CompleteBloodCountDetailData().Get(id);
            var mapper = MapperService<CompleteBloodCountDetail, CompleteBloodCountDetailDTO>.GetMapper();
            return mapper.Map<CompleteBloodCountDetailDTO>(data);
        }
    }
}
