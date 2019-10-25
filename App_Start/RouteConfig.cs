using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "CostumerDetails",
                "Costumers/{action}/{id}", 
                new { controller = "Costumers", action = "Costumer", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Costumers",
                url: "Costumers",
                defaults: new { controller = "Costumers", action = "Costumers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Costumers", action = "Costumers"}
            );
        }
    }
}
