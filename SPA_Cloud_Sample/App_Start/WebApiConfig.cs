using Microsoft.Practices.Unity;
using SPA_Cloud_Sample.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SPA_Cloud_Sample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IContactRepository, ContactRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
            
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
