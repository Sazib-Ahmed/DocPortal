using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RequestScheduleService
    {
        public static List<RequestScheduleDTO> GetAll()
        {
            var data = DataAccessFactory.RequestScheduleData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RequestSchedule, RequestScheduleDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<RequestScheduleDTO>>(data);
            return conv;
        }
        public static bool Create(RequestScheduleDTO obj)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RequestScheduleDTO, RequestSchedule>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<RequestSchedule>(obj);
            var res = DataAccessFactory.RequestScheduleData().Create(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Update(RequestScheduleDTO requestschedule)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RequestScheduleDTO, RequestSchedule>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<RequestSchedule>(requestschedule);
            var res = DataAccessFactory.RequestScheduleData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.RequestScheduleData().Delete(id);
        }
    }
}
