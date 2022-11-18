using NewsPortal_BusinessLogicLayer.DTOs;
using NewsPortal_BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal_MVC_AppLayer.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            var data = NewsService.GetAllNews();
            return View(data);
        }



        [HttpGet]
        public ActionResult AddNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNews(NewsDTO c)
        {
            if (ModelState.IsValid)
            {
                NewsService.AddNews(c);
                return RedirectToAction("Index");
            }

            return View();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(NewsService.GetNews(id));
        }
        [HttpPost]
        public ActionResult Edit(NewsDTO c)
        {
            if (ModelState.IsValid)
            {
                NewsService.EditNews(c);
                return RedirectToAction("Index");
            }
            TempData["msg"] = "Fill up all fields";
            return RedirectToAction("Edit");
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(NewsService.GetNews(id));
        }
        [HttpPost]
        public ActionResult Delete(NewsDTO c)
        {
            NewsService.DeleteNews(c);
            return RedirectToAction("Index");
        }
    }
}