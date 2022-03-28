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
        // GET: Department
        public ActionResult Index()
        {
            JK_Tech_DBEntities entities = new JK_Tech_DBEntities();          
            return View(entities.Departments.ToList());
        }
    }
}