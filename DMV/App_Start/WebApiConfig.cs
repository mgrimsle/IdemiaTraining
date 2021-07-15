using DMV.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DMV.App_Start;
using Newtonsoft.Json.Serialization;

namespace DMV
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
<<<<<<< Updated upstream

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new CamelCasePropertyNamesContractResolver();
=======
            AutofacConfig.Register();
>>>>>>> Stashed changes
            // Web API configuration and services
            // Web API routes
            AutofacConfig.Register();
            config.MapHttpAttributeRoutes();

        }
    }
}
