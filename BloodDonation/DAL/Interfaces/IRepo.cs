using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IRepo <CLASS, ID, RESULT>
    {
        List<CLASS> Get();
        CLASS Get(ID id);
        RESULT Add(CLASS obj);
        bool Delete(ID id);
        bool Edit(CLASS obj);
    }
}
