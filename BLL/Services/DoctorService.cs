using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repo;
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
            var data= DoctorRepo.GetAll();
            var config = new MapperConfiguration(cfg => {
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
            return DoctorRepo.Create(conv);
        }

        public static Doctor GetById(int id)
        {
            var data = DoctorRepo.GetById(id);
            return data;
        }
    }
}
