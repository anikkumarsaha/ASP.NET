using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var db = new AssociationEntities();
            var AllStudents = db.Students.ToList();
            return View(AllStudents);
        }



        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Student st)
        {
            var db = new AssociationEntities();
            db.Students.Add(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Students
                       where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Students
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            ext.Name = s.Name;
            ext.Dob = s.Dob;
            ext.Gender = s.Gender;
            ext.Cgpa = s.Cgpa;
            ext.DepartmentId = s.DepartmentId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Students
                       where st.Id == id
                       select st).SingleOrDefault();
            return View(ext);
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            var db = new AssociationEntities();
            var ext = (from st in db.Students
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            db.Students.Remove(ext);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}