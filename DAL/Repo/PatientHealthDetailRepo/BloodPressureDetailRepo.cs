using DAL.EF;
using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class BloodPressureDetailRepo : Repo, IRepo<BloodPressureDetail, int, bool>
    {

        public List<BloodPressureDetail> Get()
        {
            return db.BloodPressureDetails.ToList();
        }

        public BloodPressureDetail Get(int id)
        {
            return db.BloodPressureDetails.Find(id);
        }

        public bool Create(BloodPressureDetail obj)
        {
            db.BloodPressureDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(BloodPressureDetail updatedObj)
        {
            var exobj = Get(updatedObj.BloodPressureDetailId);
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
                db.BloodPressureDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
