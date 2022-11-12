using RepositoryPatterns.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatterns.Repository
{
    public class EmployeeRepository
    {
        static ZeroHungerEntities db;

        static EmployeeRepository()
        {
            db = new ZeroHungerEntities();
        }

        public static Employee GetEmployee(int id)
        {
            var e = (from em in db.Employees
                     where em.Id == id
                     select em).SingleOrDefault();

            var ee = db.Employees.SingleOrDefault(em => em.Id == id);
            return e;
        }
        public static List<Employee> GetAllEmployee()
        {
            return db.Employees.ToList();
        }
    }
}