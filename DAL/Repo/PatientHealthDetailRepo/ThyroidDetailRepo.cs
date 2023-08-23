using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class ThyroidDetailRepo : Repo, IRepo<ThyroidDetail, int, bool>
    {
        public List<ThyroidDetail> Get()
        {
            return db.ThyroidDetails.ToList();
        }

        public ThyroidDetail Get(int id)
        {
            return db.ThyroidDetails.Find(id);
        }

        public bool Create(ThyroidDetail obj)
        {
            db.ThyroidDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(ThyroidDetail updatedObj)
        {
            var exobj = Get(updatedObj.ThyroidDetailId);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(updatedObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            if (obj != null)
            {
                db.ThyroidDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
