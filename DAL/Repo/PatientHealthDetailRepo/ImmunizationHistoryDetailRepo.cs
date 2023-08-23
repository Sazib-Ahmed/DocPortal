using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class ImmunizationHistoryDetailRepo : Repo, IRepo<ImmunizationHistoryDetail, int, bool>
    {
        public List<ImmunizationHistoryDetail> Get()
        {
            return db.ImmunizationHistoryDetails.ToList();
        }

        public ImmunizationHistoryDetail Get(int id)
        {
            return db.ImmunizationHistoryDetails.Find(id);
        }

        public bool Create(ImmunizationHistoryDetail obj)
        {
            db.ImmunizationHistoryDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(ImmunizationHistoryDetail updatedObj)
        {
            var exobj = Get(updatedObj.ImmunizationHistoryDetailId);
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
                db.ImmunizationHistoryDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
