using AutoMapper;
using BLL.DTOs.PatientHealthDetailDTO;
using BLL.DTOs;
using DAL.EF.Models.PatientHealthDetail;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.EF.Models.Doctor;
using static DAL.EF.Models.PatientHealth;

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


    // This class is used to map between DTOs and EF models for PatientHealth because it has an enum type
    internal class PatientHealthMapperService<Src, Dest>
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>()
                   .ReverseMap();

                //mapping  BloodType enum
                cfg.CreateMap<BloodGroup, BloodGroup>(); // Assuming BloodType is the enum type

            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }

    internal class PatientHealthDetailMapperService
    {

        public static Mapper GetDetailMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Src, Dest>().ReverseMap();
                cfg.CreateMap<PatientHealth, PatientHealthPatientHealthDetailDTO>();
                cfg.CreateMap<BloodGroup, BloodGroup>();
                cfg.CreateMap<BloodPressureDetail, BloodPressureDetailDTO>();
                cfg.CreateMap<HemoglobinDetail, HemoglobinDetailDTO>();
                cfg.CreateMap<XrayDetail, XrayDetailDTO>();
                cfg.CreateMap<MRIDetail, MRIDetailDTO>();
                cfg.CreateMap<CTScanDetail, CTScanDetailDTO>();
                cfg.CreateMap<GlucoseLevelDetail, GlucoseLevelDetailDTO>();
                cfg.CreateMap<CholesterolLevelDetail, CholesterolLevelDetailDTO>();
                cfg.CreateMap<ThyroidDetail, ThyroidDetailDTO>();
                cfg.CreateMap<LiverFunctionDetail, LiverFunctionDetailDTO>();
                cfg.CreateMap<KidneyFunctionDetail, KidneyFunctionDetailDTO>();
                cfg.CreateMap<CompleteBloodCountDetail, CompleteBloodCountDetailDTO>();
                cfg.CreateMap<UrineAnalysisDetail, UrineAnalysisDetailDTO>();
                cfg.CreateMap<ECGDetail, ECGDetailDTO>();
                cfg.CreateMap<PulmonaryFunctionDetail, PulmonaryFunctionDetailDTO>();
                cfg.CreateMap<VitaminLevelsDetail, VitaminLevelsDetailDTO>();
                cfg.CreateMap<CancerMarkersDetail, CancerMarkersDetailDTO>();
                cfg.CreateMap<ImmunizationHistoryDetail, ImmunizationHistoryDetailDTO>();
                cfg.CreateMap<OtherTestDetail, OtherTestDetailDTO>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }

}
