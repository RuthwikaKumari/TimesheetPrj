﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TimesheetPrj
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
;
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Times", action = "Display", id = UrlParameter.Optional }

            );

            //routes.MapRoute(
            //    name: "IsUsernameExist",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Times", action = "Display", id = UrlParameter.Optional }

            //);
        }
    }
}
