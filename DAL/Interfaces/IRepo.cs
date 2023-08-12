using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID,RET>
    {
        List<CLASS> GetAll();
        CLASS GetById(ID id);
        RET Create(CLASS obj);
        RET Update(CLASS obj);
        bool Delete(ID id);
    }
}
