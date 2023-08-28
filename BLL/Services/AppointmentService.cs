using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.DTOs;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppointmentService
    {
        public static List<AppointmentDTO> GetAll()
        {
            var data = DataAccessFactory.AppointmentData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Appointment, AppointmentDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<AppointmentDTO>>(data);
            return conv;
        }

        public static bool Create(AppointmentDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AppointmentDTO, Appointment>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<Appointment>(obj);
            return DataAccessFactory.AppointmentData().Create(conv);
        }

        public static AppointmentDTO GetById(int id)
        {
            var data = DataAccessFactory.AppointmentData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Appointment, AppointmentDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<AppointmentDTO>(data);
            return conv;
        }

        public static bool Update(AppointmentDTO obj)
        {
            var mapper = MapperService<AppointmentDTO, Appointment>.GetMapper();
            var mapped = mapper.Map<Appointment>(obj);
            return DataAccessFactory.AppointmentData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AppointmentData().Delete(id);
        }

        public static List<AppointmentDTO> GetByDoctor(int doctorId)
        {
            var data = (from a in DataAccessFactory.AppointmentData().Get()
                        where a.DoctorId == doctorId
                        select a).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Appointment, AppointmentDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<AppointmentDTO>>(data);
            return conv;
        }

        public static List<AppointmentDTO> GetByPatient(int patientId)
        {
            var data = (from a in DataAccessFactory.AppointmentData().Get()
                        where a.PatientId == patientId
                        select a).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Appointment, AppointmentDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<AppointmentDTO>>(data);
            return conv;
        }
    }
}