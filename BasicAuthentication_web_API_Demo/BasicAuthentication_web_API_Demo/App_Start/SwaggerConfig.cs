using System.Web.Http;
using WebActivatorEx;
using BasicAuthentication_web_API_Demo;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace BasicAuthentication_web_API_Demo
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                       c.SingleApiVersion("v1", "BasicAuthentication_web_API_Demo");                       
                       // c.IncludeXmlComments(string.Format(@"{0}\bin\BasicAuthentication_web_API_Demo.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.InjectJavaScript(thisAssembly, "BasicAuthentication_web_API_Demo.Custom.basic-authentication.js");
                    });
        }
    }
}