using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class OtherTestDetailRepo : Repo, IRepo <OtherTestDetail, int, bool>
    {
        public List<OtherTestDetail> Get()
        {
            return db.OtherTestDetails.ToList();
        }

        public OtherTestDetail Get(int id)
        {
            return db.OtherTestDetails.Find(id);
        }

        public bool Create(OtherTestDetail obj)
        {
            db.OtherTestDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(OtherTestDetail updatedObj)
        {
            var exobj = Get(updatedObj.OtherTestDetailId);
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
                db.OtherTestDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
