using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersDemo.Models;

namespace HtmlHelpersDemo.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> emplist = new List<Employee>() {
            new Employee() { Id = 1, Name = "Shilpa", Gender = "Female", Salary = 9000 },
              new Employee() { Id = 2, Name = "shylaja", Gender = "Female", Salary = 9000 },
                new Employee() { Id = 3, Name = "Kousar", Gender = "Female", Salary = 9000 },
              new Employee() { Id = 4, Name = "Ranjitha", Gender = "Female", Salary = 9000 },
            };
            return View(emplist);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            Session["emp"] = employee;
            ViewBag.emp = employee;

            return View();
        }
    }
}