using AutoMapper;
using BLL.DTOs;
using BLL.Secrets;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BLL.Services
{
    public class DoctorService
    {
        // More modular and organized approach by separating the mapping concerns into a separate service class.
        public static List<DoctorDTO> GetAll()
        {
            var data = DataAccessFactory.DoctorData().Get();
            var mapper = DoctorMapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<List<DoctorDTO>>(data);
        }


        public static bool Create(DoctorDTO obj)
        {
            string password = Cryptography.EncryptPassword(obj.Password);
            obj.Password= password;
            var mapper = DoctorMapperService<DoctorDTO, Doctor>.GetMapper();
            var mapped = mapper.Map<Doctor>(obj);
            return DataAccessFactory.DoctorData().Create(mapped);
        }

        

        public static DoctorDTO GetById(int id)
        {
            var data = DataAccessFactory.DoctorData().Get(id);
            var mapper = DoctorMapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<DoctorDTO>(data);
        }

        public static bool Update(DoctorDTO post)
        {
            var mapper = DoctorMapperService<DoctorDTO, Doctor>.GetMapper();
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
            var mapper = DoctorMapperService<Doctor, DoctorDTO>.GetMapper();
            return mapper.Map<List<DoctorDTO>>(data);
        }


        public static string SetImageName(String RegistrationNumber)
        {
              Random rnd = new Random();
            int ranNum = rnd.Next(10000000, 99999999);
            string imageName = "sample";
            if (RegistrationNumber == null)
            {
                imageName = "DOC" + ranNum;
            }
            if (RegistrationNumber != null)
            {
                imageName = ranNum + RegistrationNumber;
            }
            String iName = imageName + ".png";
            return iName;
        }

        public static bool UploadImage(byte[] imageData, string RegistrationNumber)
        {
            try
            {
                var iName = SetImageName(RegistrationNumber);
                // send the image data to the data access layer
                bool imageUploadResult = DataAccessFactory.PutDoctorImageData().UploadImage(imageData, iName);

                return imageUploadResult;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public static byte[] GetDoctorImage(int id)
        {
            try
            {

                var data = (from n in DataAccessFactory.DoctorData().Get()
                        where n.DoctorId == id
                        select n).FirstOrDefault();
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Doctor, DoctorDTO>();
                });

                  var mapper = new Mapper(config);
                  var conv = mapper.Map<DoctorDTO>(data);

                string imageName = data.Image;

               // var data = DataAccessFactory.DoctorData().Get().Where(n => n.DoctorId==id);
                // Fetch the image data from the repository based on the doctorId
                // For example, you can create a method in the data access layer that retrieves the image data
                // using the provided doctorId and returns it as byte[]


                byte[] imageData = DataAccessFactory.GetDoctorImageData().GetImage(imageName);

                return imageData;
            }
            catch (Exception)
            {
                // Handle exceptions and log if necessary
                return null; // Return null in case of error
            }
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
