using NewsPortal_BusinessLogicLayer.DTOs;
using NewsPortal_BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_MVC_AppLayer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View(CategoryService.GetAllCategories());
        }



        [HttpGet]
        public ActionResult AddNewCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewCategory(CategoryDTO c)
        {
            if (ModelState.IsValid)
            {
                CategoryService.AddCategory(c);
                return RedirectToAction("Index");
            }

            return View();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(CategoryService.GetCategory(id));
        }
        [HttpPost]
        public ActionResult Edit(CategoryDTO c)
        {
            if (ModelState.IsValid)
            {
                CategoryService.EditCategory(c);
                return RedirectToAction("Index");
            }
            TempData["msg"] = "Name field required";
            return RedirectToAction("Edit");
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(CategoryService.GetCategory(id));
        }
        [HttpPost]
        public ActionResult Delete(CategoryDTO c)
        {
            CategoryService.DeleteCategory(c);
            return RedirectToAction("Index");
        }
    }
}