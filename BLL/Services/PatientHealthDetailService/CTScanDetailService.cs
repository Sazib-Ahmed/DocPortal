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
    public class CTScanDetailService
    {
        public static List<CTScanDetailDTO> GetAll()
        {
            var data = DataAccessFactory.CTScanDetailData().Get();
            var mapper = MapperService<CTScanDetail, CTScanDetailDTO>.GetMapper();
            return mapper.Map<List<CTScanDetailDTO>>(data);
        }

        public static bool Create(CTScanDetailDTO obj)
        {
            var mapper = MapperService<CTScanDetailDTO, CTScanDetail>.GetMapper();
            var mapped = mapper.Map<CTScanDetail>(obj);
            return DataAccessFactory.CTScanDetailData().Create(mapped);
        }

        public static bool Update(CTScanDetailDTO obj)
        {
            var mapper = MapperService<CTScanDetailDTO, CTScanDetail>.GetMapper();
            var mapped = mapper.Map<CTScanDetail>(obj);
            return DataAccessFactory.CTScanDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CTScanDetailData().Delete(id);
        }

        public static CTScanDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.CTScanDetailData().Get(id);
            var mapper = MapperService<CTScanDetail, CTScanDetailDTO>.GetMapper();
            return mapper.Map<CTScanDetailDTO>(data);
        }

        public static List<CTScanDetailDTO> GetCTScanDetailByPatientId(int patientId)
        {
            var data = DataAccessFactory.CTScanDetailData().Get().Where(d => d.PatientId == patientId).ToList();
            var mapper = MapperService<CTScanDetail, CTScanDetailDTO>.GetMapper();
            return mapper.Map<List<CTScanDetailDTO>>(data);
        }



    }
}
