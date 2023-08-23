using DAL.EF.Models.PatientHealthDetail;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.PatientHealthDetailRepo
{
    internal class CancerMarkersDetailRepo : Repo, IRepo<CancerMarkersDetail, int, bool>
    {
        public List<CancerMarkersDetail> Get()
        {
                return db.CancerMarkersDetails.ToList();
            }
    
            public CancerMarkersDetail Get(int id)
        {
                return db.CancerMarkersDetails.Find(id);
            }
    
            public bool Create(CancerMarkersDetail obj)
        {
                db.CancerMarkersDetails.Add(obj);
                return db.SaveChanges() > 0;
            }
    
            public bool Update(CancerMarkersDetail updatedObj)
        {
                var exobj = Get(updatedObj.CancerMarkersDetailId);
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
                    db.CancerMarkersDetails.Remove(obj);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
    }
}
