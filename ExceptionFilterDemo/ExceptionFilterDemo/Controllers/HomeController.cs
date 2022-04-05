using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterDemo.Controllers
{
    
    [HandleError(ExceptionType =typeof(NullReferenceException),View ="NullReference")]
    [HandleError(ExceptionType = typeof(DivideByZeroException), View = "divideByZero")]
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
            //return View();
        }

        public ActionResult TestMethod1()
        {
            throw new NullReferenceException();
        }

        public ActionResult TestMethod2()
        {
            throw new DivideByZeroException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Something wrong");
            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}