using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
//using System.Web.Http;
//using System.Web.Http.Cors;

namespace CodeFirst
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ////Enable others ports for any method any header any 
            //var rules = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(rules);
            //// Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
