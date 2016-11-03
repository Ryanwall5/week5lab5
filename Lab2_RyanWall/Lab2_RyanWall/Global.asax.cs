using System.Web.Mvc;
using System.Web.Routing;
using Lab2_RyanWall.App_Start;

namespace Lab2_RyanWall
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DependencyInjectionConfig.Register();
        }
    }
}
