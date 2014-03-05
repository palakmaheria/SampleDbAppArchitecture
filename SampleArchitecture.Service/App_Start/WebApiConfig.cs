//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="WebApiConfig.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   Represents web api config class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service
{
    using System.Web.Http;

    /// <summary>
    /// The web api config.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="config"> The config. </param>
        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services

            //// Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.EnsureInitialized();
        }
    }
}
