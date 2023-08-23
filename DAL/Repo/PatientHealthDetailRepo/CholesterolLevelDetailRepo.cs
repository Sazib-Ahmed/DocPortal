using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class CholesterolLevelDetailRepo : Repo, IRepo<CholesterolLevelDetail, int, bool>
    {
        public List<CholesterolLevelDetail> Get()
        {
            return db.CholesterolLevelDetails.ToList();
        }

        public CholesterolLevelDetail Get(int id)
        {
            return db.CholesterolLevelDetails.Find(id);
        }

        public bool Create(CholesterolLevelDetail obj)
        {
            db.CholesterolLevelDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(CholesterolLevelDetail updatedObj)
        {
            var exobj = Get(updatedObj.CholesterolLevelDetailId);
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
                db.CholesterolLevelDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
