#region Copyright Pist
//-------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents a global class 
// </summary>
//-------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Service
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using SampleArchitecture.Service.Infrastructure;

    /// <summary>
    /// The web application.
    /// </summary>
    public class Global : System.Web.HttpApplication
    {        
        /// <summary>
        /// object for resolve
        /// </summary>
        private readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            this.bootstrapper.Initialize();
        }
    }
}
