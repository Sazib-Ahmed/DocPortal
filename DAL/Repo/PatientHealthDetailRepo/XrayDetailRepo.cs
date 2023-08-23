using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class XrayDetailRepo : Repo, IRepo<XrayDetail, int, bool>
    {
        public List<XrayDetail> Get()
        {
            return db.XrayDetails.ToList();
        }

        public XrayDetail Get(int id)
        {
            return db.XrayDetails.Find(id);
        }

        public bool Create(XrayDetail obj)
        {
            db.XrayDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(XrayDetail updatedObj)
        {
            var exobj = Get(updatedObj.XrayDetailId);
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
                db.XrayDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
