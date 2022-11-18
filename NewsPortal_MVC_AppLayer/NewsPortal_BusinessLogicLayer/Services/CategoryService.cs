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
    public class CategoryService
    {
        public static void AddCategory(CategoryDTO c)
        {
            Category cat = new Category();
            cat.Name = c.Name;
            new CategoryRepo().Add(cat); 
        }



        public static List<CategoryDTO> GetAllCategories()
        {
            var c = new CategoryRepo();
            var List = new List<CategoryDTO>();
            foreach (var item in c.GetAll())
            {
                List.Add(new CategoryDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                });
            }
            return List;
        }



        public static CategoryDTO GetCategory(int id)
        {
            var c = new CategoryRepo();
            var data = c.Get(id);

            var cat = new CategoryDTO();
            cat.Id = data.Id;
            cat.Name = data.Name;

            return cat;
        }



        public static void EditCategory(CategoryDTO c)
        {
            var cat = new Category();
            cat.Id = c.Id;
            cat.Name = c.Name;

            var category = new CategoryRepo();
            category.Edit(cat);
        }



        public static void DeleteCategory(CategoryDTO c)
        {
            var cat = new Category();
            cat.Id = c.Id;

            var category = new CategoryRepo();
            category.Delete(cat.Id);
        }
    }
}
