using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class TempDataDemoController : Controller
    {
        public ActionResult Method1()
        {
            TempData["Name"] = "Geetha";
            TempData["Designation"] = "consultant";
            return View();
        }

        public ActionResult Method2()
        {
            TempData["gender"] = "female";
            string ename, edesignation;
            ename = "";
            edesignation = "";
            //if (TempData.ContainsKey("Name"))
            //    ename = TempData["Name"].ToString();
            //else
            //    ename = "there is no Tempdata with Name key available";
            //if (TempData.ContainsKey("Designation"))
            //    edesignation = TempData["Designation"].ToString();
            TempData.Keep();
            return View();
           
        }

        public string Method3()
        {
            string name1=""; string deisgnation1="";string gender = "";
            if (TempData.ContainsKey("Name"))
                name1 = TempData["Name"].ToString();
            if (TempData.ContainsKey("Designation"))
                deisgnation1 = TempData["Designation"].ToString();
            if (TempData.ContainsKey("gender"))
                gender = TempData["gender"].ToString();
           TempData.Keep();
            return name1 + "- "+deisgnation1+" -"+gender;
        }
        // GET: TempDataDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}