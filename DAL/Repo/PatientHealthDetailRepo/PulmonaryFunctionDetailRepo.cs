using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class PulmonaryFunctionDetailRepo : Repo, IRepo<PulmonaryFunctionDetail, int, bool>
    {
        public List<PulmonaryFunctionDetail> Get()
        {
            return db.PulmonaryFunctionDetails.ToList();
        }

        public PulmonaryFunctionDetail Get(int id)
        {
            return db.PulmonaryFunctionDetails.Find(id);
        }

        public bool Create(PulmonaryFunctionDetail obj)
        {
            db.PulmonaryFunctionDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(PulmonaryFunctionDetail updatedObj)
        {
            var exobj = Get(updatedObj.PulmonaryFunctionDetailId);
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
                db.PulmonaryFunctionDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
