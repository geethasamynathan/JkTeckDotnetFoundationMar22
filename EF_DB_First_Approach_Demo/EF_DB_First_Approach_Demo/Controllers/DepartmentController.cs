using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_DB_First_Approach_Demo.Models;

namespace EF_DB_First_Approach_Demo.Controllers
{
    public class DepartmentController : Controller
    {

        JK_Tech_DBEntities entities = new JK_Tech_DBEntities();
        // GET: Department
        public ActionResult Index()
        {      
            return View(entities.Departments.ToList());
        }
     
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            entities.Departments.Add(department);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Department dept = entities.Departments.Find(id);
            return View(dept);
        }
        [HttpPost]
        public ActionResult Edit(Department department)
        {

            entities.Departments.Attach(department);
            entities.Entry(department).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Department dept1 = entities.Departments.Find(id);
            return View(dept1);
        }
        public ActionResult Delete(int id)
        {
            Department dept = entities.Departments.Find(id);

            return View(dept);
        }
        [HttpPost]
        public ActionResult Delete(int id,Department department)
        {
            Department dept = entities.Departments.Find(id);
            entities.Departments.Remove(dept);           
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}