using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstProject_C.Controllers
{
    public class BasicController : IController
    {
        public BasicController()
        {


        }
        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("<h2>Understanding Controller");
            requestContext.HttpContext.Response.Write("ActionName : "+requestContext.RouteData.Values["action"]);

        }
    }
}