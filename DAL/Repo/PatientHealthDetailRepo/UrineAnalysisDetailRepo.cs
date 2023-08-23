using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class UrineAnalysisDetailRepo : Repo, IRepo <UrineAnalysisDetail, int, bool>
    {
        public List<UrineAnalysisDetail> Get()
        {
            return db.UrineAnalysisDetails.ToList();
        }

        public UrineAnalysisDetail Get(int id)
        {
            return db.UrineAnalysisDetails.Find(id);
        }

        public bool Create(UrineAnalysisDetail obj)
        {
            db.UrineAnalysisDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(UrineAnalysisDetail updatedObj)
        {
            var exobj = Get(updatedObj.UrineAnalysisDetailId);
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
                db.UrineAnalysisDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
