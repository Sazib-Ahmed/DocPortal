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
    public class PatientService
    {

        public static List<PatientDTO> GetAll()
        {
            var data = DataAccessFactory.PatientData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PatientDTO>>(data);
            return conv;
        }


        public static bool Create(PatientDTO obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientDTO, Patient>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<Patient>(obj);
            return DataAccessFactory.PatientData().Create(conv);
        }

        public static PatientDTO GetById(int id)
        {
            var data = DataAccessFactory.PatientData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<PatientDTO>(data);
            return conv;
        }


        public static bool Update(PatientDTO post)
        {
            var mapper = MapperService<PatientDTO, Patient>.GetMapper();
            var mapped = mapper.Map<Patient>(post);
            return DataAccessFactory.PatientData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PatientData().Delete(id);
        }


        public static List<PatientDTO> GetByName(string name)
        {
            var data = (from n in DataAccessFactory.PatientData().Get()
                        where n.Name.ToLower().Contains(name.ToLower())
                        select n).ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<PatientDTO>>(data);
            return conv;
        }



    }
}
