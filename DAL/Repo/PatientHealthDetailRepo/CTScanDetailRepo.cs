using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class CTScanDetailRepo : Repo, IRepo<CTScanDetail, int, bool>
    {
        public List<CTScanDetail> Get()
        {
            return db.CTScanDetails.ToList();
        }

        public CTScanDetail Get(int id)
        {
            return db.CTScanDetails.Find(id);
        }

        public bool Create(CTScanDetail obj)
        {
            db.CTScanDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(CTScanDetail updatedObj)
        {
            var exobj = Get(updatedObj.CTScanDetailId);
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
                db.CTScanDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
