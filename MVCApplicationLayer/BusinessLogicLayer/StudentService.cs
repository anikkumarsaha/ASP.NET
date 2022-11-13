using BusinessLogicLayer.DTO;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class StudentService
    {
        public static List<StudentDTO> GetStudents()
        {
            var list = new List<StudentDTO>();
            foreach (var item in StudentRepo.Get())
            {
                list.Add(new StudentDTO()
                {
                    Id = item.id,
                    Name = item.name,
                });
            }
            return list;
        }
    }
}
