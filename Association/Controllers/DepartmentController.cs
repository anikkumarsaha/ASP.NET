using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            var db = new AssociationEntities();
            var AllDepartments = db.Departments.ToList();
            return View(AllDepartments);
        }



        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Department st)
        {
            var db = new AssociationEntities();
            db.Departments.Add(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Departments
                       where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
        [HttpPost]
        public ActionResult Edit(Department s)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Departments
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            ext.Name = s.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Departments
                       where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
        [HttpPost]
        public ActionResult Delete(Department s)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Departments
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            db.Departments.Remove(ext);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Details(int id)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Departments
                       where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
    }
}