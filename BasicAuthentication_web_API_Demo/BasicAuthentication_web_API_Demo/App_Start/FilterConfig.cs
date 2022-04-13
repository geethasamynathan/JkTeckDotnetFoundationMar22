using System.Web;
using System.Web.Mvc;

namespace BasicAuthentication_web_API_Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
