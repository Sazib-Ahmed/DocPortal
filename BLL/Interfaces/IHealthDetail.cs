using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IHealthDetail<CLASS, ID, RET>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RET Create(CLASS obj);
        RET Update(CLASS obj);
        bool Delete(ID id);
    }
    //GetALL() , Create() , Update() , Delete() , GetById() , GetByPatientHealthId()

}
