using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Threading;
using System.Web.Http;

namespace BasicAuthentication_web_API_Demo.Models
{
    public class BasicAuthenticationAttribue:AuthorizeAttribute

    {
        private const string Realm = "My Realm";
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            base.HandleUnauthorizedRequest(actionContext);
        }
        //protected override bool IsAuthorized(HttpActionContext actionContext)
        //{
        //    if (actionContext.Request.Headers.Authorization == null)
        //    {
        //        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
        //    }
        //    if (actionContext.Response.StatusCode == HttpStatusCode.Unauthorized)
        //    {
        //        actionContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", Realm));
        //    }
        //    else
        //    {
        //        string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
        //        string decodedAuthenticationToken = Encoding.UTF8.GetString(
        //            Convert.FromBase64String(authenticationToken));
        //        string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
        //        string username = usernamePasswordArray[0];
        //        string password = usernamePasswordArray[1];
        //        if (UserValidate.Login(username, password))
        //        {
        //            var idenity = new GenericIdentity(username);
        //            IPrincipal principal = new GenericPrincipal(idenity, null);
        //            Thread.CurrentPrincipal = principal;
        //            if (HttpContext.Current != null)
        //            {
        //                HttpContext.Current.User = principal;
        //            }
        //            return true;
        //        }
        //        else
        //        {
        //            //actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
        //            return false;
        //        }
        //    }
        //}
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization==null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            //if (actionContext.Response.StatusCode == HttpStatusCode.Unauthorized)
            //{
            //    actionContext.Response.Headers.Add("WWW-Authenticate", string.Format("Basic realm=\"{0}\"", Realm));
            //}
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedAuthenticationToken = Encoding.UTF8.GetString(
                    Convert.FromBase64String(authenticationToken));
                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];
                if(UserValidate.Login(username,password))
                {
                    var idenity = new GenericIdentity(username);
                    IPrincipal principal = new GenericPrincipal(idenity, null);
                    Thread.CurrentPrincipal = principal;
                    if(HttpContext.Current !=null)
                    {
                        HttpContext.Current.User = principal;
                    }
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}