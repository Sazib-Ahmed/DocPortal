using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class KidneyFunctionDetailRepo : Repo, IRepo <KidneyFunctionDetail, int, bool>
    {
        public List<KidneyFunctionDetail> Get()
        {
            return db.KidneyFunctionDetails.ToList();
        }

        public KidneyFunctionDetail Get(int id)
        {
            return db.KidneyFunctionDetails.Find(id);
        }

        public bool Create(KidneyFunctionDetail obj)
        {
            db.KidneyFunctionDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(KidneyFunctionDetail updatedObj)
        {
            var exobj = Get(updatedObj.KidneyFunctionDetailId);
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
                db.KidneyFunctionDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
