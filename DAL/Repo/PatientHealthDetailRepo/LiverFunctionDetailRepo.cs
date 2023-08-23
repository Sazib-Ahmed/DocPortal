using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class LiverFunctionDetailRepo : Repo, IRepo<LiverFunctionDetail, int, bool>
    {
        public List<LiverFunctionDetail> Get()
        {
            return db.LiverFunctionDetails.ToList();
        }

        public LiverFunctionDetail Get(int id)
        {
            return db.LiverFunctionDetails.Find(id);
        }

        public bool Create(LiverFunctionDetail obj)
        {
            db.LiverFunctionDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(LiverFunctionDetail updatedObj)
        {
            var exobj = Get(updatedObj.LiverFunctionDetailId);
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
                db.LiverFunctionDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }  
}
