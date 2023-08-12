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
    internal class PrescriptionRepo : Repo, IRepo<Prescription, int, bool>
    {
        public List<Prescription> Get()
        {
            return db.Prescriptions.ToList();
        }

        public Prescription Get(int id)
        {
            return db.Prescriptions.Find(id);
        }

        public bool Create(Prescription obj)
        {
            db.Prescriptions.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Prescription updatedObj)
        {
            var exobj = Get(updatedObj.PrescriptionId);
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
                db.Prescriptions.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
