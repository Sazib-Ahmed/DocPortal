using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PrescriptionDetailRepo : Repo, IRepo<PrescriptionDetail, int, bool>
    {
        public List<PrescriptionDetail> GetAll()
        {   
            return db.PrescriptionDetails.ToList();  
        }

        public PrescriptionDetail GetById(int id)
        {
            return db.PrescriptionDetails.Find(id);
        }

        public bool Create(PrescriptionDetail obj)
        {
            db.PrescriptionDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(PrescriptionDetail updatedObj)
        {
            var exobj = GetById(updatedObj.PrescriptionDetailId);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(updatedObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var obj = GetById(id);
            if (obj != null)
            {
                db.PrescriptionDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
