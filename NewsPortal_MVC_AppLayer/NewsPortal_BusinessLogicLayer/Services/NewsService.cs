using NewsPortal_BusinessLogicLayer.DTOs;
using NewsPortal_DataAccessLayer.EF;
using NewsPortal_DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal_BusinessLogicLayer.Services
{
    public class NewsService
    {
        public static void AddNews(NewsDTO c)
        {
            News cat = new News();
            cat.Title = c.Title;
            cat.CategoryId = c.CategoryId;
            cat.Date = c.Date;
            new NewsRepo().Add(cat);
        }



        public static List<NewsDTO> GetAllNews()
        {
            var c = new NewsRepo();
            var List = new List<NewsDTO>();
            foreach (var item in c.GetAll())
            {
                List.Add(new NewsDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    CategoryId = item.CategoryId,
                    Date = item.Date,
                });
            }
            return List;
        }



        public static NewsDTO GetNews(int id)
        {
            var c = new NewsRepo();
            var data = c.Get(id);

            var cat = new NewsDTO();
            cat.Id = data.Id;
            cat.Title = data.Title;
            cat.CategoryId = data.CategoryId;
            cat.Date = data.Date;

            return cat;
        }



        public static void EditNews(NewsDTO c)
        {
            var cat = new News();
            cat.Id = c.Id;
            cat.Title = c.Title;
            cat.CategoryId = c.CategoryId;
            cat.Date = c.Date;

            var news = new NewsRepo();
            news.Edit(cat);
        }



        public static void DeleteNews(NewsDTO c)
        {
            var cat = new News();
            cat.Id = c.Id;

            var news = new NewsRepo();
            news.Delete(cat.Id);
        }
    }
}
