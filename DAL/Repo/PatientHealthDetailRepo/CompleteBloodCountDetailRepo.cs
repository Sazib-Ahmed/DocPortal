using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class CompleteBloodCountDetailRepo : Repo, IRepo<CompleteBloodCountDetail, int, bool>
    {
        public List<CompleteBloodCountDetail> Get()
        {
            return db.CompleteBloodCountDetails.ToList();
        }

        public CompleteBloodCountDetail Get(int id)
        {
            return db.CompleteBloodCountDetails.Find(id);
        }

        public bool Create(CompleteBloodCountDetail obj)
        {
            db.CompleteBloodCountDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(CompleteBloodCountDetail updatedObj)
        {
            var exobj = Get(updatedObj.CompleteBloodCountDetailId);
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
                db.CompleteBloodCountDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
