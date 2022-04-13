using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BasicAuthentication_web_API_Demo.Models;
using System.Threading;
using Microsoft.Graph;

namespace BasicAuthentication_web_API_Demo.Controllers
{
    public class EmployeeController : ApiController
    {
        
        [Authorize]
        public HttpResponseMessage GetEmployees()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;

            var Emplist = new EmployeeBL().GetEmployees();
            switch (username.ToLower())
            {
                case "maleuser":
                    return Request.CreateResponse(HttpStatusCode.OK, Emplist.Where(e => e.Gender.ToLower() == "male").ToList());
                case "femaleuser":
                    return Request.CreateResponse(HttpStatusCode.OK, Emplist.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

        }
    }
}
