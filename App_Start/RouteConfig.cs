using MyFirstProject_C.UtilityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstProject_C
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //).RouteHandler=new CustomRouteHandler();

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //).RouteHandler = new MvcRouteHandler();



            //Route route = new Route("{controller}/{action}", new CustomRouteHandler());

            //routes.Add(route);

            Route route = new Route("{controller}/{action}", new MvcRouteHandler());

            routes.Add(route);

            //routes.MapRoute(
            //    name: "MyRoute",
            //    url: "{controller}/{action}/{*id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },new string[]
            //    {

            //        "MyFirstProject_C.Controllers"
            //    }
            //);

        }
    }
}
