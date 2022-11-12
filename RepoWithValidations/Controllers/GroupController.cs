using RepoWithValidations.Models;
using RepoWithValidations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoWithValidations.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(GroupModel g)
        {
            if (ModelState.IsValid)
            {
                GroupRepository.AddGroup(g);
                TempData["msg"] = "OK";
                return RedirectToAction("Index");
            }
            TempData["msg"] = "NOT OK";
            return View("Index");
        }
    }
}