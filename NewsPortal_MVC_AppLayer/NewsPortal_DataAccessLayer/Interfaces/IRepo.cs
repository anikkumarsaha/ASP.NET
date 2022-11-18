using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal_DataAccessLayer.Interfaces
{
    public interface IRepo<CLASS, ID>
    {
        List<CLASS> GetAll();
        CLASS Get(ID id);
        void Add(CLASS obj);
        void Edit(CLASS obj);
        void Delete(ID id);
    }
}
