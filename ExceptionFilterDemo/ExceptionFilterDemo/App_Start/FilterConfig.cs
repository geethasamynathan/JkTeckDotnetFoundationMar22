using System.Web;
using System.Web.Mvc;
using ExceptionFilterDemo.Models;

namespace ExceptionFilterDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogCustomExceptionFilter());
        }
    }
}
