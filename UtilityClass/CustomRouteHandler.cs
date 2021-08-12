using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MyFirstProject_C.UtilityClass
{

    public class CustomRouteHandler : IRouteHandler

    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new CustomHttpHandler();
        }

    }

    public class CustomHttpHandler : IHttpHandler
    {
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Understanding Of Custom Routing");
        }
    }
}