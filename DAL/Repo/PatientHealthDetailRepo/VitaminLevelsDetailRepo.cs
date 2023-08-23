using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class VitaminLevelsDetailRepo : Repo, IRepo<VitaminLevelsDetail, int, bool>
    {
        public List<VitaminLevelsDetail> Get()
        {
            return db.VitaminLevelsDetails.ToList();
        }

        public VitaminLevelsDetail Get(int id)
        {
            return db.VitaminLevelsDetails.Find(id);
        }

        public bool Create(VitaminLevelsDetail obj)
        {
            db.VitaminLevelsDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(VitaminLevelsDetail updatedObj)
        {
            var exobj = Get(updatedObj.VitaminLevelsDetailId);
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
                db.VitaminLevelsDetails.Remove(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    } 
}
