using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PrescriptionRepo
    {
        public static List<Prescription> GetAll()
        {
            using (var db = new DocPortalContext())
            {
                return db.Prescriptions.ToList();
            }
        }

        public static bool Create(Prescription obj)
        {
            using (var db = new DocPortalContext())
            {
                db.Prescriptions.Add(obj);
                return db.SaveChanges() > 0;
            }
        }

        public static Prescription GetById(int id)
        {
            using (var db = new DocPortalContext())
            {
                return db.Prescriptions.Find(id);
            }
        }

        public static void Update(Prescription obj)
        {
            using (var db = new DocPortalContext())
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(Prescription obj)
        {
            using (var db = new DocPortalContext())
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
