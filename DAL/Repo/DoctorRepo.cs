using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DoctorRepo : Repo, IRepo<Doctor, int, bool>, IAuth<Doctor>, IImageHandler<byte[], string, bool> //, IImageService<byte[], string>
    {
        public bool UploadImage(byte[] image, string imageName)
        {
            try
            {
                string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "./DAL");
                string imagesFolder = Path.Combine(rootFolder, "AppData", "DoctorImages");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }
                string imagePath = Path.Combine(imagesFolder, imageName + ".png");


                using (FileStream fileStream = new FileStream(imagePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fileStream.Write(image, 0, image.Length);
                }
                return true; // Image upload successful
            }
            catch (Exception)
            {
                // Log the exception
                return false; // Image upload failed
            }
        }
        public byte[] GetImage(string imageName)
        {
            string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "./DAL");
            string imagesFolder = Path.Combine(rootFolder, "AppData", "DoctorImages");

            if (Directory.Exists(imagesFolder))
            {
                string imagePath = Path.Combine(imagesFolder, imageName);

                if (File.Exists(imagePath))
                {
                    var imageData = File.ReadAllBytes(imagePath);
                    return imageData;
                }
            }

            return null;
        }
        public List<Doctor> Get()
        {
            return db.Doctors.ToList();
        }

        public bool Create(Doctor obj)
        {

            db.Doctors.Add(obj);
            return db.SaveChanges() > 0;
        }

        public Doctor Get(int id)
        {
            return db.Doctors.Find(id);
        }

        public bool Update(Doctor updatedObj)
        {
            var exobj = Get(updatedObj.DoctorId);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(updatedObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var existingObj = Get(id);
            if (existingObj != null)
            {
                db.Doctors.Remove(existingObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        //public Doctor Authenticate(string email, string password)
        //{
        //    var doctor = from d in db.Doctors
        //                 where d.Email == email && d.Password == password
        //                 select d;
        //    if(doctor != null) return doctor.SingleOrDefault();
        //    return null;
        //}

        public Doctor Authenticate(string email, string password)
        {
            var doctor = db.Doctors.FirstOrDefault(d => d.Email == email && d.Password == password);
            return doctor;
        }


    }
}
