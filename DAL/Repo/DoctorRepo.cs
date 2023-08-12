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
    internal class DoctorRepo : Repo, IRepo<Doctor, int, bool>

    {
        public List<Doctor> GetAll()
        {

            return db.Doctors.ToList();
        }

        public bool Create(Doctor obj)
        {

            db.Doctors.Add(obj);
            return db.SaveChanges() > 0; //returns true if more than 0 rows are affected
            //db.SaveChanges() returns the number of rows affected
        }

        public Doctor GetById(int id)
        {
            return db.Doctors.Find(id);
        }

        public bool Update(Doctor updatedObj) 
        {
            var exobj = GetById(updatedObj.Id);
            if (exobj != null)
            {
                db.Entry(exobj).CurrentValues.SetValues(updatedObj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var exobj = GetById(id);
            db.Doctors.Remove(exobj);
            return db.SaveChanges()>0;
        }

    }
}
