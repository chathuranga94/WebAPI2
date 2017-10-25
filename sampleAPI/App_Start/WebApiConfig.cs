﻿using Microsoft.Practices.Unity;
using sampleAPI.Interfaces;
using sampleAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace sampleAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var container = new UnityContainer();
            container.RegisterType<IProductsService, ProductService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new Resolver.UnityResolver(container);
        }
       
    }
}
