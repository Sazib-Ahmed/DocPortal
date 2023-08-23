using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class GlucoseLevelDetailRepo : Repo, IRepo <GlucoseLevelDetail, int, bool>
    {
        public List<GlucoseLevelDetail> Get()
        {
            return db.GlucoseLevelDetails.ToList();
        }

        public GlucoseLevelDetail Get(int id)
        {
            return db.GlucoseLevelDetails.Find(id);
        }

        public bool Create(GlucoseLevelDetail obj)
        {
            db.GlucoseLevelDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(GlucoseLevelDetail updatedObj)
        {
            var exobj = Get(updatedObj.GlucoseLevelDetailId);
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
                db.GlucoseLevelDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
