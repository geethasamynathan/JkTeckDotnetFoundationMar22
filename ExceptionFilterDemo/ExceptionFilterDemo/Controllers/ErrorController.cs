﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterDemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult PageNotFoundError()
        {
            return View();
        }
        public ActionResult InternalServerError()
        {
            return View();
        }
        public ActionResult UnauthorizedError()
        {
            return View();
        }
        public ActionResult GenericError()
        {
            return View();
        }
    }
}