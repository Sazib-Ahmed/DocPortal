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
    
        internal class AppointmentRepo : Repo, IRepo<Appointment, int, bool>
        {
            public List<Appointment> Get()
            {
                return db.Appointments.ToList();
            }

            public bool Create(Appointment obj)
            {
                db.Appointments.Add(obj);
                return db.SaveChanges() > 0;
            }

            public Appointment Get(int id)
            {
                return db.Appointments.Find(id);
            }

            public bool Update(Appointment updatedObj)
            {
                var exobj = Get(updatedObj.AppointmentId);
                if (exobj != null)
                {
                    db.Entry(exobj).CurrentValues.SetValues(updatedObj);
                    return db.SaveChanges() > 0;
                }
                return false;
            }

            public bool Delete(int id)
            {
                var exobj = Get(id);
                db.Appointments.Remove(exobj);
                return db.SaveChanges() > 0;
            }
        }
    }

