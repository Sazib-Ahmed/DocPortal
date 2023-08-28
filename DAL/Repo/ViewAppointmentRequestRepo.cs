using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ViewAppointmentRequestRepo : Repo , IRepo<ViewAppointmentRequest, int, ViewAppointmentRequest>
    {
        public ViewAppointmentRequest Create(ViewAppointmentRequest obj)
        {
            db.ViewAppointmentRequests.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.ViewAppointmentRequests.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<ViewAppointmentRequest> Get()
        {
            return db.ViewAppointmentRequests.ToList();
        }

        public ViewAppointmentRequest Get(int id)
        {
            return db.ViewAppointmentRequests.Find(id);
        }

        public ViewAppointmentRequest Update(ViewAppointmentRequest obj)
        {
            var exdata = db.ViewAppointmentRequests.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
