using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repo
{
    internal class PatientTokenRepo : Repo, IRepo<PatientToken, int, PatientToken>
    {
        public List<PatientToken> Get()
        {
            return db.PatientTokens.ToList();
        }

        public PatientToken Create(PatientToken obj)
        {
            db.PatientTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public PatientToken Get(int id)
        {
            return db.PatientTokens.Find(id);
        }

        public PatientToken Update(PatientToken updatedObj)
        {
            var existingObj = Get(updatedObj.PatientTokenId);
            if (existingObj != null)
            {
                db.Entry(existingObj).CurrentValues.SetValues(updatedObj);
                if (db.SaveChanges() > 0) return updatedObj;
                return null;
            }
            return existingObj;
        }

        public bool Delete(int id)
        {
            var existingObj = Get(id);
            if (existingObj != null)
            {
                db.PatientTokens.Remove(existingObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}