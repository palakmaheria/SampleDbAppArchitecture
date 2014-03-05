//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="ControllerInstaller.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents controller installer class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Infrastructure
{
    using System;
    using System.Web.Http;
    using System.Web.Mvc;

    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Castle Windsor Controller responsible for registering classes managed by
    /// the IoC container.
    /// This implementation registers all MVC Controllers (IController).
    /// </summary>
    public class ControllerInstaller : IWindsorInstaller
    {
        /// <summary>
        /// Implementation registers all MVC Controllers (IController).
        /// </summary>
        /// <param name="container"> windsor container. </param>
        /// <param name="store"> Configuration store. </param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var directoryfilter = new AssemblyFilter("bin");

            if (container == null)
            {
                return;
            }

            //// Resolve all Mappings
            container.Register(Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("Mapping", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve all repositories
            container.Register(
                Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("ObjectContext", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve all repositories
            container.Register(
                Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("Repository", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve all business layers
            container.Register(
                Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("Business", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve all database connection manager
            container.Register(
                Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("ConnectionManager", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve all Operation manager
            container.Register(
                Classes.FromAssemblyInDirectory(directoryfilter)
                    .Where(x => x.IsPublic && x.Namespace != null && x.Namespace.EndsWith("OperationManager", StringComparison.Ordinal))
                    .WithService.DefaultInterfaces()
                    .LifestyleTransient());

            //// Resolve Basic Controller 
            container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestylePerWebRequest());

            //// Resolve WebAPI
            container.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestylePerWebRequest());
        }
    }
}