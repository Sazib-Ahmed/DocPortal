using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.EF.Models.Doctor;

namespace BLL.Services
{
    // This class is used to map between DTOs and EF models
    internal class MapperService<Src, Dest>
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>().ReverseMap();
            }
            );
            var mapper = new Mapper(config);
            return mapper;
        }
    }

    // This class is used to map between DTOs and EF models for Doctor because it has an enum type
    internal class DoctorMapperService<Src, Dest>
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>()
                   .ReverseMap();

                //mapping  DGender enum
                cfg.CreateMap<DGender, DGender>(); // Assuming DGender is the enum type

            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
