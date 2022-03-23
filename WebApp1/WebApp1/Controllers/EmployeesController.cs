using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> emplist = new List<Employee>() {
             new Employee() { Empid = 101, Name = "Mohan", Gender = "Male", Salary = 230000 },
             new Employee() { Empid = 102, Name = "Vishwas", Gender = "Male", Salary = 240000 },
             new Employee() { Empid = 103, Name = "Pavani", Gender = "Female", Salary = 270000 },
            new Employee() { Empid = 104, Name = "Nethra", Gender = "Female", Salary = 290000 },

             };
            //ViewData["emp"] = employee;
           // ViewBag.emp1 = employee;
            //ViewData["empid"] = "101";

            //ViewData["empname"] = "Geetha";
            //ViewData["gender"] = "Female";

            //ViewBag.eid = 102;
            //ViewBag.ename = "Raju";
            //ViewBag.gendr = "male";

            

            return View(emplist);
        }
    }
}