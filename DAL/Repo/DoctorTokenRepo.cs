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
    internal class DoctorTokenRepo : Repo, IRepo<DoctorToken, int, DoctorToken>
    {
        
        public List<DoctorToken> Get()
        {
            return db.DoctorTokens.ToList();
        }

        public DoctorToken Create(DoctorToken obj)
        {
            db.DoctorTokens.Add(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }

        public DoctorToken Get(int id)
        {
            return db.DoctorTokens.Find(id);
        }

        public DoctorToken Update(DoctorToken updatedObj)
        {
            var existingObj = Get(updatedObj.DoctorTokenId);
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
                db.DoctorTokens.Remove(existingObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        //DoctorToken IRepo<DoctorToken, int, DoctorToken>.Create(DoctorToken obj)
        //{
        //    throw new NotImplementedException();
        //}

        //DoctorToken IRepo<DoctorToken, int, DoctorToken>.Update(DoctorToken obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
