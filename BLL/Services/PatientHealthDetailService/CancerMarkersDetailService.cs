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
    public class CancerMarkersDetailService
    {
        public static List<CancerMarkersDetailDTO> GetAll()
        {
            var data = DataAccessFactory.CancerMarkersDetailData().Get();
            var mapper = MapperService<CancerMarkersDetail, CancerMarkersDetailDTO>.GetMapper();
            return mapper.Map<List<CancerMarkersDetailDTO>>(data);
        }

        public static bool Create(CancerMarkersDetailDTO obj)
        {
            var mapper = MapperService<CancerMarkersDetailDTO, CancerMarkersDetail>.GetMapper();
            var mapped = mapper.Map<CancerMarkersDetail>(obj);
            return DataAccessFactory.CancerMarkersDetailData().Create(mapped);
        }

        public static bool Update(CancerMarkersDetailDTO obj)
        {
            var mapper = MapperService<CancerMarkersDetailDTO, CancerMarkersDetail>.GetMapper();
            var mapped = mapper.Map<CancerMarkersDetail>(obj);
            return DataAccessFactory.CancerMarkersDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CancerMarkersDetailData().Delete(id);
        }

        public static CancerMarkersDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.CancerMarkersDetailData().Get(id);
            var mapper = MapperService<CancerMarkersDetail, CancerMarkersDetailDTO>.GetMapper();
            return mapper.Map<CancerMarkersDetailDTO>(data);
        }


        public static List<CancerMarkersDetailDTO> GetCancerMarkersDetailByPatientId(int patientId)
        {

            var cancerMarkersDetailData = DataAccessFactory.CancerMarkersDetailData().Get();

            var data = (from cm in cancerMarkersDetailData
                       where cm.PatientId == patientId
                       select cm).ToList();

            var mapper = MapperService<CancerMarkersDetail, CancerMarkersDetailDTO>.GetMapper();
            return mapper.Map<List<CancerMarkersDetailDTO>>(data);
        }

        
    }
}
