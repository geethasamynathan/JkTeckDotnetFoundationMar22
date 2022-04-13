﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BasicAuthentication_web_API_Demo.Models;
namespace BasicAuthentication_web_API_Demo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new BasicAuthenticationAttribue());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
