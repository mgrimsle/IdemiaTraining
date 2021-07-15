using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DMV
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Hello
            //fjsdafsdkfsdjf;adsjf;j
            //SUP 
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
