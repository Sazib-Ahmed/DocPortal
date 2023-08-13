using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
   
    

        internal class PatientRepo : Repo, IRepo<Patient, int, bool>
        {
            public List<Patient> Get()
            {
                return db.Patients.ToList();
            }

            public bool Create(Patient obj)
            {
                db.Patients.Add(obj);
                return db.SaveChanges() > 0;
            }

            public Patient Get(int id)
            {
                return db.Patients.Find(id);
            }

            public bool Update(Patient updatedObj)
            {
                var exobj = Get(updatedObj.Id);
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
                db.Patients.Remove(exobj);
                return db.SaveChanges() > 0;
            }
        }
    }

