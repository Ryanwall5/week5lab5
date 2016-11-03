using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Lab2_RyanWall.Data;
using Lab2_RyanWall.Services;
using System.Reflection;
using System.Web.Mvc;

namespace Lab2_RyanWall.App_Start
{
    public static class DependencyInjectionConfig
    {
        public static void Register()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Register your types, for instance:
            container.Register<IRepository, EfRepository>();
            container.Register<IUserService, UserService>();
            container.Register<ICoolRatingService, CoolRatingService >();

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}