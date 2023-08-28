using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class RequestScheduleRepo : Repo, IRepo<RequestSchedule, int, RequestSchedule>
    {
        public RequestSchedule Create(RequestSchedule obj)
        {
            db.RequestSchedules.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.RequestSchedules.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<RequestSchedule> Get()
        {
            return db.RequestSchedules.ToList();
        }

        public RequestSchedule Get(int id)
        {
            return db.RequestSchedules.Find(id);
        }

        public RequestSchedule Update(RequestSchedule obj)
        {
            var exdata = db.RequestSchedules.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
