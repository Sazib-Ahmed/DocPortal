using AutoMapper;
using BLL.DTOs;
using BLL.APIs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrescriptionDetailService
    {
        public static List<PrescriptionDetailDTO> GetAll()
        {
            var data = DataAccessFactory.PrescriptionDetailData().Get();
            var mapper = DoctorMapperService<PrescriptionDetail, PrescriptionDetailDTO>.GetMapper();
            return mapper.Map<List<PrescriptionDetailDTO>>(data);
        }

        public static PrescriptionDetailDTO GetById(int id)
        {
            var data = DataAccessFactory.PrescriptionDetailData().Get(id);
            var mapper = DoctorMapperService<PrescriptionDetail, PrescriptionDetailDTO>.GetMapper();
            return mapper.Map<PrescriptionDetailDTO>(data);
        }

        public static bool Create(PrescriptionDetailDTO obj)
        {
            var mapper = DoctorMapperService<PrescriptionDetailDTO, PrescriptionDetail>.GetMapper();
            var mapped = mapper.Map<PrescriptionDetail>(obj);
            return DataAccessFactory.PrescriptionDetailData().Create(mapped);
        }

        public static bool Update(PrescriptionDetailDTO obj)
        {
            var mapper = DoctorMapperService<PrescriptionDetailDTO, PrescriptionDetail>.GetMapper();
            var mapped = mapper.Map<PrescriptionDetail>(obj);
            return DataAccessFactory.PrescriptionDetailData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.PrescriptionDetailData().Delete(id);
        }

        public static List<PrescriptionDetailDTO> GetByPrescriptionId(int id)
        {
            var data = (from n in DataAccessFactory.PrescriptionDetailData().Get()
                        where n.PrescriptionId == id
                        select n).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PrescriptionDetail, PrescriptionDetailDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PrescriptionDetailDTO>>(data);
            return conv;
        }

        public static PrescriptionDetailDTO GetByIdToBN(int id,string to)
        {
            string TranslateFrom = "en";
            string TranslateTo = to;
            var data = DataAccessFactory.PrescriptionDetailData().Get(id);
            MapperService<PrescriptionDetail, PrescriptionDetailDTO>.GetMapper();
            var presDetail = new PrescriptionDetailDTO()
            {
                PrescriptionDetailId = data.PrescriptionDetailId,
                PrescriptionId = data.PrescriptionId,
                Medication = APIUsed.Translate(data.Medication, TranslateFrom, TranslateTo),
                Dosage = APIUsed.Translate(data.Dosage, TranslateFrom, TranslateTo),
                Instructions = APIUsed.Translate(data.Instructions, TranslateFrom, TranslateTo)
            };
            return presDetail;
        }




        //public static string  Translate(string input, string from, string to)
        //{
        //    var fromLanguage = from;
        //    var toLanguage = to;
        //    var encodedInput = Uri.EscapeDataString(input);
        //    var url = $"https://translate.google.com/translate_a/single?client=gtx&sl{fromLanguage}&tl={toLanguage}&dt=t&q={encodedInput}";

        //    using (var webClient = new WebClient
        //    {
        //        Encoding = System.Text.Encoding.UTF8
        //    })
        //    {
        //        var result = webClient.DownloadString(url);
        //        try
        //        {
        //            result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
        //            return result;
        //        }
        //        catch (Exception)
        //        {
        //            return "error";
        //        }
        //    }
        //}
    }
}
