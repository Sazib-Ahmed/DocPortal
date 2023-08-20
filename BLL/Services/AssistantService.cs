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
    public class AssistantService
    {
        public static List<AssistantDTO> GetAll()
        {
            var data = DataAccessFactory.AssistantData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Assistant, AssistantDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<AssistantDTO>>(data);
            return conv;
        }
        public static bool Create(AssistantDTO obj)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AssistantDTO, Assistant>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Assistant>(obj);
            var res = DataAccessFactory.AssistantData().Create(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Update(AssistantDTO assistant)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AssistantDTO, Assistant>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Assistant>(assistant);
            var res = DataAccessFactory.AssistantData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AssistantData().Delete(id);
        }

    }
}
