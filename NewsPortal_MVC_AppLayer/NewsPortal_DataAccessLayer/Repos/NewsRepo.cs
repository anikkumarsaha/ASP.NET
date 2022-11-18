using NewsPortal_DataAccessLayer.EF;
using NewsPortal_DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal_DataAccessLayer.Repos
{
    public class NewsRepo : IRepo<News, int>
    {
        public void Add(News obj)
        {
            var db = new NewsPortalEntities();
            db.News.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var db = new NewsPortalEntities();
            var data = (from d in db.News
                        where d.Id == id
                        select d).SingleOrDefault();
            db.News.Remove(data);
            db.SaveChanges();
        }

        public void Edit(News obj)
        {
            var db = new NewsPortalEntities();
            var data = (from d in db.News
                        where d.Id == obj.Id
                        select d).SingleOrDefault();
            data.Title = obj.Title;
            data.Date = obj.Date;
            data.CategoryId = obj.CategoryId;
            db.SaveChanges();
        }

        public News Get(int id)
        {
            var db = new NewsPortalEntities();
            var data = (from c in db.News
                        where c.Id == id
                        select c).FirstOrDefault();
            return data;
        }

        public List<News> GetAll()
        {
            var db = new NewsPortalEntities();
            return db.News.ToList();
        }
    }
}
