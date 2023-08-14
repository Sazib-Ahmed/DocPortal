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
        


        // More modular and organized approach by separating the mapping concerns into a separate service class.
        public static List<DoctorDTO> GetAll()
        {
            var data = DataAccessFactory.DoctorData().Get();
            var mapper = MapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<List<DoctorDTO>>(data);
        }


        public static bool Create(DoctorDTO obj)
        {
            var mapper = MapperService<Doctor, DoctorDTO>.GetMapper();
            var data = mapper.Map<Doctor>(obj);
            return DataAccessFactory.DoctorData().Create(data);
        }

        public static DoctorDTO GetById(int id)
        {
            var data = DataAccessFactory.DoctorData().Get(id);
            var mapper = MapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<DoctorDTO>(data);
        }

        public static bool Update(DoctorDTO post)
        {
            var mapper = MapperService<DoctorDTO, Doctor>.GetMapper();
            var mapped = mapper.Map<Doctor>(post);
            return DataAccessFactory.DoctorData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.DoctorData().Delete(id);
        }

        public static List<DoctorDTO> GetByName(string name)
        {
            var data = DataAccessFactory.DoctorData().Get().Where(n => n.Name.ToLower().Contains(name.ToLower()));
            var mapper = MapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<List<DoctorDTO>>(data);
        }





        // ## Less modular and organized approach by not separating the mapping concerns into a separate service class.

        //public static List<DoctorDTO> GetAll()
        //{
        //    var data= DataAccessFactory.DoctorData().Get();
        //    var config = new MapperConfiguration(cfg => {
        //        cfg.CreateMap<Doctor, DoctorDTO>(); 
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<List<DoctorDTO>>(data);
        //    return conv;
        //}

        //public static List<DoctorDTO> GetByName(string name)
        //{
        //    var data = (from n in DataAccessFactory.DoctorData().Get()
        //                where n.Name.ToLower().Contains(name.ToLower())
        //                select n).ToList();
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Doctor, DoctorDTO>();
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<List<DoctorDTO>>(data);
        //    return conv;
        //}

        //public static bool Create(DoctorDTO obj)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<DoctorDTO, Doctor>();
        //    });

        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<Doctor>(obj);
        //    return DataAccessFactory.DoctorData().Create(conv);
        //}

        //public static DoctorDTO GetById(int id)
        //{

        //    var data = DataAccessFactory.DoctorData().Get(id);
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<Doctor, DoctorDTO>();
        //    });
        //    var mapper = new Mapper(config);
        //    var conv = mapper.Map<DoctorDTO>(data);
        //    return conv;
        //}



    }
}
