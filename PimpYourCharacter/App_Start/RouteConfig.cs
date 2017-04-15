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
                name: "Accessoire",
                url: "Accessoire/{action}",
                defaults: new { controller = "Accessoire", action = "Index" });

            routes.MapRoute(
                name: "Arme",
                url: "Arme/{action}",
                defaults: new { controller = "Arme", action = "Index" });

            routes.MapRoute(
                name: "Bouche",
                url: "Bouche/{action}",
                defaults: new { controller = "Bouche", action = "Index" });

            routes.MapRoute(
                name: "Bouclier",
                url: "Bouclier/{action}",
                defaults: new { controller = "Bouclier", action = "Index" });

            routes.MapRoute(
                name: "Bras",
                url: "Bras/{action}",
                defaults: new { controller = "Bras", action = "Index" });

            routes.MapRoute(
                name: "Buste",
                url: "Buste/{action}",
                defaults: new { controller = "Buste", action = "Index" });

            routes.MapRoute(
                name: "CategorieArme",
                url: "CategorieArme/{action}",
                defaults: new { controller = "CategorieArme", action = "Index" });

            routes.MapRoute(
                name: "CategorieAccess",
                url: "CategorieAccess/{action}",
                defaults: new { controller = "CategorieAccess", action = "Index" });

            routes.MapRoute(
                name: "Corps",
                url: "Corps/{action}",
                defaults: new { controller = "Corps", action = "Index" });

            routes.MapRoute(
                name: "Couleurs",
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
                name: "Ethnie",
                url: "Ethnie/{action}",
                defaults: new { controller = "Ethnie", action = "Index" });

            routes.MapRoute(
                name: "Genre",
                url: "Genre/{action}",
                defaults: new { controller = "Genre", action = "Index" });

            routes.MapRoute(
                name: "Jambe",
                url: "Jambe/{action}",
                defaults: new { controller = "Jambe", action = "Index" });

            routes.MapRoute(
                name: "Nez",
                url: "Nez/{action}",
                defaults: new { controller = "Nez", action = "Index" });

            routes.MapRoute(
                name: "Personnage",
                url: "Personnage/{action}",
                defaults: new { controller = "Personnage", action = "Index" });

            routes.MapRoute(
                name: "Tete",
                url: "Tete/{action}",
                defaults: new { controller = "Tete", action = "Index" });

            routes.MapRoute(
                name: "Texture",
                url: "Texture/{action}",
                defaults: new { controller = "Texture", action = "Index" });

            routes.MapRoute(
                name: "Yeux",
                url: "Yeux/{action}",
                defaults: new { controller = "Yeux", action = "Index" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
