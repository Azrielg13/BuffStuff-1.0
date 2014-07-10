using BuffStuff.Implementation;
using BuffStuff.Implementation.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BuffStuff.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new ContextDbInitializer());//drops database and creates a new one to match changes by clearing stored hash
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            //greedy and takes the first match

            routes.Ignore("{resource}.axd/{*pathInfo");

            routes.MapRoute(
                "Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search" }
            );

            //default route
            routes.MapRoute(
                "Default",//Route name
                //Home/Index
            "{controller}/{action}/{id}", //url with params
            new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }

    
}
