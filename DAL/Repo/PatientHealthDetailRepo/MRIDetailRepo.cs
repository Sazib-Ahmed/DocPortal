using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class MRIDetailRepo : Repo, IRepo<MRIDetail, int, bool>
    {
        public List<MRIDetail> Get()
        {
            return db.MRIDetails.ToList();
        }

        public MRIDetail Get(int id)
        {
            return db.MRIDetails.Find(id);
        }

        public bool Create(MRIDetail obj)
        {
            db.MRIDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(MRIDetail updatedObj)
        {
            var exobj = Get(updatedObj.MRIDetailId);
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
                db.MRIDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
