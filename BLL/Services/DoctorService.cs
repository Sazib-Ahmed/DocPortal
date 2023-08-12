using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorService
    {
        public static List<DoctorDTO> GetAll()
        {
            var data= DataAccessFactory.DoctorData().GetAll();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Doctor, DoctorDTO>(); 
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<DoctorDTO>>(data);
            return conv;
        }
        public static List<DoctorDTO> GetByName(string name)
        {
            var data = (from n in DataAccessFactory.DoctorData().GetAll()
                        where n.Name.ToLower().Contains(name.ToLower())
                        select n).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Doctor, DoctorDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<DoctorDTO>>(data);
            return conv;
        }

        public static bool Create(DoctorDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DoctorDTO, Doctor>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<Doctor>(obj);
            return DataAccessFactory.DoctorData().Create(conv);
        }

        public static DoctorDTO GetById(int id)
        {

            var data= DataAccessFactory.DoctorData().GetById(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Doctor, DoctorDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<DoctorDTO>(data);
            return conv;
        }
    }
}
