﻿using System.Web;
using System.Web.Mvc;

namespace Attributes_in_MVC_Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
