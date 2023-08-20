using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repo
{
    internal class AssistantRepo : Repo, IRepo<Assistant, int, Assistant>
    {
        public Assistant Create(Assistant obj)
        {
            db.Assistants.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Assistants.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Assistant> Get()
        {
            return db.Assistants.ToList();
        }

        public Assistant Get(int id)
        {
            return db.Assistants.Find(id);
        }

        public Assistant Update(Assistant obj)
        {
            var exdata = db.Assistants.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
