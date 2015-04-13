using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace TuevSued.V1.IT.FE.MasterDataModuleWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "TaxCopySave",
                routeTemplate: "api/taxcopy/save/{id}",
                defaults: new { controller = "taxcopy", action = "save" }
            );

            config.Routes.MapHttpRoute(
               name: "TaxCopyRemove",
               routeTemplate: "api/taxcopy/remove/{id}",
               defaults: new { controller = "taxcopy", action = "remove" }
            );

            config.Routes.MapHttpRoute(
              name: "TaxCopyGet",
              routeTemplate: "api/taxcopy/get/{id}",
              defaults: new { controller = "taxcopy", action = "get" }
           );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
