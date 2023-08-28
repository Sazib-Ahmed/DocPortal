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
    public class ViewAppointmentRequestService
    {
        public static List<ViewAppointmentRequestDTO> GetAll()
        {
            var data = DataAccessFactory.ViewAppointmentRequestData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ViewAppointmentRequest, ViewAppointmentRequestDTO>();
            });

            var mapper = new Mapper(config);
            var conv = mapper.Map<List<ViewAppointmentRequestDTO>>(data);
            return conv;
        }
        public static bool Create(ViewAppointmentRequestDTO obj)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ViewAppointmentRequestDTO, ViewAppointmentRequest>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ViewAppointmentRequest>(obj);
            var res = DataAccessFactory.ViewAppointmentRequestData().Create(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Update(ViewAppointmentRequestDTO viewappointmentrequest)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ViewAppointmentRequestDTO, ViewAppointmentRequest>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ViewAppointmentRequest>(viewappointmentrequest);
            var res = DataAccessFactory.ViewAppointmentRequestData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ViewAppointmentRequestData().Delete(id);
        }
    }
}
