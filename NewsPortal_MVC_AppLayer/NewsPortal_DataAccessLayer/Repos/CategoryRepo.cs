using NewsPortal_DataAccessLayer.EF;
using NewsPortal_DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal_DataAccessLayer.Repos
{
    public class CategoryRepo : IRepo<Category, int>
    {
        public void Add(Category obj)
        {
            var db = new NewsPortalEntities();
            db.Categories.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new NewsPortalEntities();
            var data = (from d in db.Categories
                        where d.Id == id
                        select d).SingleOrDefault();
            db.Categories.Remove(data);
            db.SaveChanges();
        }

        public void Edit(Category obj)
        {
            var db = new NewsPortalEntities();
            var data = (from d in db.Categories
                        where d.Id == obj.Id
                        select d).SingleOrDefault();
            data.Name = obj.Name;
            db.SaveChanges();
        }

        public Category Get(int id)
        {
            var db = new NewsPortalEntities();
            var data = (from c in db.Categories
                       where c.Id == id
                       select c).FirstOrDefault();
            return data;
        }

        public List<Category> GetAll()
        {
            var db = new NewsPortalEntities();
            return db.Categories.ToList();
        }
    }
}
