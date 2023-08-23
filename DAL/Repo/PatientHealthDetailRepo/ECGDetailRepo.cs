using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class ECGDetailRepo : Repo, IRepo<ECGDetail, int, bool>
    {
        public List<ECGDetail> Get()
        {
            return db.ECGDetails.ToList();
        }

        public ECGDetail Get(int id)
        {
            return db.ECGDetails.Find(id);
        }

        public bool Create(ECGDetail obj)
        {
            db.ECGDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(ECGDetail updatedObj)
        {
            var exobj = Get(updatedObj.ECGDetailId);
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
                db.ECGDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
