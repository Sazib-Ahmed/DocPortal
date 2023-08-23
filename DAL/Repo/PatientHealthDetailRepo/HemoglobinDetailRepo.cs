using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class HemoglobinDetailRepo : Repo, IRepo<HemoglobinDetail, int, bool>
    {
        public List<HemoglobinDetail> Get()
        {
            return db.HemoglobinDetails.ToList();
        }

        public HemoglobinDetail Get(int id)
        {
            return db.HemoglobinDetails.Find(id);
        }

        public bool Create(HemoglobinDetail obj)
        {
            db.HemoglobinDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(HemoglobinDetail updatedObj)
        {
            var exobj = Get(updatedObj.HemoglobinDetailId);
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
                db.HemoglobinDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
