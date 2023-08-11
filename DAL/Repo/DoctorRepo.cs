using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DoctorRepo

    {
        public static List<Doctor> GetAll()
        {
            var db = new DocPortalContext();
            return db.Doctors.ToList();
        }

        public static bool Create(Doctor obj)
        {
            var db = new DocPortalContext();
            db.Doctors.Add(obj);
            return db.SaveChanges() > 0; //returns true if more than 0 rows are affected
            //db.SaveChanges() returns the number of rows affected
        }

        public static Doctor GetById(int id)
        {
            var db = new DocPortalContext();
            return db.Doctors.Find(id);
        }

        public static void Update(Doctor obj)
        {
            var db = new DocPortalContext();
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(Doctor obj)
        {
            var db = new DocPortalContext();
            db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }



    }
}
