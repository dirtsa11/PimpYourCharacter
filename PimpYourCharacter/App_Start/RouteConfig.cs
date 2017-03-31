using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PimpYourCharacter
{
    public class RouteConfig
    { 
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Couleur",
                url: "Couleurs/{action}",
                defaults: new { controller = "Couleurs", action = "Index" });
            routes.MapRoute(
                name: "Nez",
                url: "Nez/{action}",
                defaults: new { controller = "Nez", action = "Index" });
            routes.MapRoute(
                name: "Jambes",
                url: "Jambes/{action}",
                defaults: new { controller = "Jambes", action = "Index" });
            routes.MapRoute(
                name: "Bras",
                url: "Bras/{action}",
                defaults: new { controller = "Bras", action = "Index" });
            routes.MapRoute(
                name: "Bustes",
                url: "Bustes/{action}",
                defaults: new { controller = "Bustes", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
