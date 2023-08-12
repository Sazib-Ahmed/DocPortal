using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PrescriptionDetailRepo
    {
        public static List<PrescriptionDetail> GetAll()
        {
            using (var db = new DocPortalContext())
            {
                return db.PrescriptionDetails.ToList();
            }
        }

        public static bool Create(PrescriptionDetail obj)
        {
            using (var db = new DocPortalContext())
            {
                db.PrescriptionDetails.Add(obj);
                return db.SaveChanges() > 0;
            }
        }

        public static PrescriptionDetail GetById(int id)
        {
            using (var db = new DocPortalContext())
            {
                return db.PrescriptionDetails.Find(id);
            }
        }

        public static bool Update(PrescriptionDetail obj)
        {
            using (var db = new DocPortalContext())
            {
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges() > 0;
            }
        }

        public static bool Delete(int id)
        {
            using (var db = new DocPortalContext())
            {
                var obj = db.PrescriptionDetails.Find(id);
                db.PrescriptionDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
        }
    }
}
