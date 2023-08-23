using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class PatientHealthRepo : Repo, IRepo<PatientHealth, int, bool>
    {

        public List<PatientHealth> Get()
        {
            return db.PatientHealths.ToList();
        }

        public PatientHealth Get(int id)
        {
            return db.PatientHealths.Find(id);
        }

        public bool Create(PatientHealth obj)
        {
            db.PatientHealths.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(PatientHealth updatedObj)
        {
            var exobj = Get(updatedObj.PatientHealthId);
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
                db.PatientHealths.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
