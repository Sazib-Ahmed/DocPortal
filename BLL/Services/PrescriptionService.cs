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
        public static List<PrescriptionDTO> GetAll()
        {
            var data = DataAccessFactory.PrescriptionData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prescription, PrescriptionDTO>(); 
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PrescriptionDTO>>(data);
            return conv;
        }

        public static bool Create(PrescriptionDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PrescriptionDTO, Prescription>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<Prescription>(obj);
            return DataAccessFactory.PrescriptionData().Create(conv);
        }

        public static PrescriptionDTO GetById(int id)
        {
            var data= DataAccessFactory.PrescriptionData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                    cfg.CreateMap<Prescription, PrescriptionDTO>();
            });
    
            var mapper = new Mapper(config);
            var conv = mapper.Map<PrescriptionDTO>(data);
            return conv;
        }

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
                        where n.Date.Date == date
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

    }
}
