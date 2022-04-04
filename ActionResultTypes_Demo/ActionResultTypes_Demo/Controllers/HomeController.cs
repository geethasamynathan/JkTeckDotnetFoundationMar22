using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ActionResultTypes_Demo.Controllers
{
    public class HomeController : Controller
    {

        //type:1
        public ActionResult ChooseyourViewbasedonDate()
        {
            if(DateTime.Now.Day%2!=0)
            {
                return View("View1");
            }
            else
            {
                return View("View2");
            }
        }
        //Type:2
        //public ViewResult Method1()
        //{
        //    return View("Index");
        //}
        //public ActionResult Index()
        //{
        //    return View("Method1");
        //}

        //partialView
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // Type:4 //JsonResiult
        //public JsonResult Index()
        //{
        //    return Json(new { id = 101, Name = "Geetha", Designation = "Consultant" },JsonRequestBehavior.AllowGet);
        //}

        //Type :5  FilEresult
        //public FileResult Index()
        //{
        //    return File("web.config", "text");
        //}
        //public FileResult Index()
        //{
        //    return File(Url.Content("~/Files/SimpleFile.txt"),"text/plain");
        //}

        //Type :6 ContentResult
        //public ContentResult Index()
        //{ return Content("<h2> welcome to ContentResult</h2>", "text/html");
        //}

        //Type :7 RedirectResult
        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.yahoo.com");
        //}

        //Type :8 RedirectToRouteResult
        //public RedirectToRouteResult Index()
        //{
        //    return RedirectToRoute(new { Controller = "Employee", action = "Index" });
        //}

        //public RedirectToRouteResult Index()
        //{
        //    return RedirectToAction("Index","Employee");
        //}
        //public ActionResult Index()
        //{
        //    return RedirectToAction("Index", "Employee");
        //}

        //Type:9 :HttpstatuscodeResult
        public HttpStatusCodeResult UnAuthorizedStatusCode()
        {
            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "You are not authorized for this page or action");
        }
        public HttpStatusCodeResult BadGateway()
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadGateway, "I dont have an idea about this Error");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public PartialViewResult sampleView()
        {
            return PartialView("_samplePartialView");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}