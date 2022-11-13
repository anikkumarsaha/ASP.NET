using DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentRepo
    {
        public static List<Student> Get()
        {
            var db = new StudentManagementEntities();

            return db.Students.ToList();
        }
    }
}
