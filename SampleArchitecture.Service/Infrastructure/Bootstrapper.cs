//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="Bootstrapper.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   Represents boot strapper class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Infrastructure
{
    using System;
    using System.Web.Http;

    using Castle.Windsor;
    using Castle.Windsor.Installer;

    using WebApiContrib.IoC.CastleWindsor;

    /// <summary>
    /// Class for initializing unity container
    /// </summary>
    public sealed class Bootstrapper : IDisposable
    {
        /// <summary>
        /// Windsor container.
        /// </summary>
        private WindsorContainer windsorContainer;

        /// <summary>
        /// Initialize unity container.
        /// </summary>
        public void Initialize()
        {
            this.BuildWindsorContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new WindsorResolver(this.windsorContainer);
        }

        /// <summary>
        /// Clean up.
        /// </summary>
        public void CleanUp()
        {
            if (this.windsorContainer == null)
            {
                return;
            }

            this.windsorContainer.Dispose();
            this.windsorContainer = null;
        }

        /// <summary>
        /// Free up the used resources
        /// </summary>
        public void Dispose()
        {
            if (this.windsorContainer == null)
            {
                return;
            }

            this.windsorContainer.Dispose();
            this.windsorContainer = null;
        }

        /// <summary>
        /// The build windsor container.
        /// </summary>
        private void BuildWindsorContainer()
        {
            this.windsorContainer = new WindsorContainer();
            this.windsorContainer.Install(FromAssembly.This());
           
            //// Not using factory
            //// ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(this.windsorContainer.Kernel));
            //// Not required to resolve individually
            //// this.windsorContainer.Register(Component.For<IFeedbackManager>().ImplementedBy<FeedbackManager>().LifestylePerWebRequest());
            //// this.windsorContainer.Register(Component.For<IQPayManager>().ImplementedBy<QPayManager>().LifestylePerWebRequest());
            //// this.windsorContainer.Register(Component.For<IUserBusiness>().ImplementedBy<UserBusiness>().LifestylePerWebRequest());
        }
    }
}