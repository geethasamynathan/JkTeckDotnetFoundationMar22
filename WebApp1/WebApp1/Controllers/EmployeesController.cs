using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;
using WebApp1.ViewModels;

namespace WebApp1.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            /*
            Employee employee = new Employee();
            employee.Empid = 201;
            employee.Name = "Shylaja";
            employee.Gender = "Female";
            employee.Salary = 9000;
            Address address = new Address();
            address.AddressId = 1;
            address.City = "Bangalore";
            address.State = "Karnataka";
            address.Country = "India";
            address.ZipCode = 434545;

            EmployeeViewModel viewmodel = new EmployeeViewModel();
            viewmodel.Employee = employee;
            viewmodel.Address = address;
            viewmodel.PageTitle = "Employee Details";
            return View(viewmodel);
            */
           // List<EmployeeViewModel> models = new List<EmployeeViewModel>();
            
            
            List<Employee> emplist = new List<Employee>() {
             new Employee() { Empid = 101, Name = "Mohan", Gender = "Male", Salary = 230000 ,AddressId=1},
             new Employee() { Empid = 102, Name = "Vishwas", Gender = "Male", Salary = 240000 ,AddressId=2},
             new Employee() { Empid = 103, Name = "Pavani", Gender = "Female", Salary = 270000 ,AddressId=3},
            new Employee() { Empid = 104, Name = "Nethra", Gender = "Female", Salary = 290000,AddressId=4 },

             };
            List<Address> addresses = new List<Address>()
            { new Address() {AddressId=1,City="Bgl",State="KA",Country="India",ZipCode=34354,},
            new Address() {AddressId=2,City="chennai",State="TN",Country="India",ZipCode=34354},
            new Address() {AddressId=3,City="hyderabad",State="TS",Country="India",ZipCode=34354},
            new Address() {AddressId=4,City="Bgl",State="KA",Country="India",ZipCode=34354},

            };
            EmployeeViewModel viewModel = new EmployeeViewModel();
            viewModel.Employee = emplist;
            viewModel.Address = addresses;
            return View(viewModel);

            //ViewData["emp"] = employee;
            // ViewBag.emp1 = employee;
            //ViewData["empid"] = "101";

            //ViewData["empname"] = "Geetha";
            //ViewData["gender"] = "Female";

            //ViewBag.eid = 102;
            //ViewBag.ename = "Raju";
            //ViewBag.gendr = "male";



         //   return View(employee);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}