using MyFirstProject_C.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace MyFirstProject_C.UtilityClass
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type t = null;

            switch (controllerName)
            {

                case "Home":
                    t = typeof(HomeController);
                    break;
                case "Login":
                    t = typeof(LoginController);
                    break;
                case "Basic":
                    t = typeof(BasicController);
                    break;
            }
            object obj = DependencyResolver.Current.GetService(t);
            return obj as IController;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disp = controller as IDisposable;
            if (disp!=null)
            {
                disp.Dispose();
            }
        }
    }
}