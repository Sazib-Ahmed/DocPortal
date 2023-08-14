using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrescriptionService
    {


        // More modular and organized approach by separating the mapping concerns into a separate service class.
        public static List<PrescriptionDTO> GetAll()
        {
            var data = DataAccessFactory.PrescriptionData().Get();
            var mapper = MapperService<Prescription, PrescriptionDTO>.GetMapper();
            return mapper.Map<List<PrescriptionDTO>>(data);
        }

        public static bool Create(PrescriptionDTO obj)
        {
            var mapper = MapperService<Prescription, PrescriptionDTO>.GetMapper();
            var data = mapper.Map<Prescription>(obj);
            return DataAccessFactory.PrescriptionData().Create(data);
        }

        public static PrescriptionDTO GetById(int id)
        {
            var data = DataAccessFactory.PrescriptionData().Get(id);
            var mapper = MapperService<Prescription, PrescriptionDTO>.GetMapper();
            return mapper.Map<PrescriptionDTO>(data);
        }

        public static bool Update(PrescriptionDTO obj)
        {
            var mapper = MapperService<PrescriptionDTO, Prescription>.GetMapper();
            var mapped = mapper.Map<Prescription>(obj);
            return DataAccessFactory.PrescriptionData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PrescriptionData().Delete(id);
        }



        // ## Less modular and less organized approach by not separating the mapping concerns into a separate service class.
        public static PrescriptionPrescriptionDetailDTO GetWithDetail(int id)
        {
            var data = DataAccessFactory.PrescriptionData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prescription, PrescriptionPrescriptionDetailDTO>();
                cfg.CreateMap<PrescriptionDetail, PrescriptionDetailDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<PrescriptionPrescriptionDetailDTO>(data);
            return conv;
        }


        public static List<PrescriptionDTO> GetByDate(DateTime date)
        {
            var data = (from n in DataAccessFactory.PrescriptionData().Get()
                        where n.PrescriptionDate.Date == date
                        select n).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prescription, PrescriptionDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PrescriptionDTO>>(data);
            return conv;
        }
        public static List<PrescriptionDTO> GetByPatientId(int id)
        {
            var data = (from n in DataAccessFactory.PrescriptionData().Get()
                        where n.PatientId == id
                        select n).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prescription, PrescriptionDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PrescriptionDTO>>(data);
            return conv;
        }
        public static List<PrescriptionDTO> GetByDoctorId(int id)
        {
            var data = (from n in DataAccessFactory.PrescriptionData().Get()
                        where n.DoctorId == id
                        select n).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prescription, PrescriptionDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PrescriptionDTO>>(data);
            return conv;
        }


        //public static List<PrescriptionDTO> GetAll()
        //{
        //    var data = DataAccessFactory.PrescriptionData().Get();
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Prescription, PrescriptionDTO>(); 
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<List<PrescriptionDTO>>(data);
        //    return conv;
        //}

        //public static bool Create(PrescriptionDTO obj)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<PrescriptionDTO, Prescription>();
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<Prescription>(obj);
        //    return DataAccessFactory.PrescriptionData().Create(conv);
        //}

        //public static PrescriptionDTO GetById(int id)
        //{
        //    var data= DataAccessFactory.PrescriptionData().Get(id);
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //            cfg.CreateMap<Prescription, PrescriptionDTO>();
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<PrescriptionDTO>(data);
        //    return conv;
        //}
    }
}
