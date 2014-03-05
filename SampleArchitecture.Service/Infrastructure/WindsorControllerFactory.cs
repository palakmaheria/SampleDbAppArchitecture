//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="WindsorControllerFactory.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   Represents windsor controller factory class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Infrastructure
{
    using System;
    using System.Globalization;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Castle.MicroKernel;

    /// <summary>
    /// Windsor controller factory.
    /// </summary>
    public sealed class WindsorControllerFactory : DefaultControllerFactory
    {
        /// <summary>
        /// Windsor kernel object.
        /// </summary>
        private readonly IKernel windsorKernel;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindsorControllerFactory"/> class.
        /// </summary>
        /// <param name="kernel"> kernel object </param>
        public WindsorControllerFactory(IKernel kernel)
        {
            if (kernel != null)
            {
                this.windsorKernel = kernel;
            }
        }

        /// <summary>
        /// Release controller.
        /// </summary>
        /// <param name="controller">  controller object  </param>
        public override void ReleaseController(IController controller)
        {
            this.windsorKernel.ReleaseComponent(controller);
        }

        /// <summary>
        /// Get controller instance.
        /// </summary>
        /// <param name="requestContext"> request context. </param>
        /// <param name="controllerType"> controller type. </param>
        /// <returns> appropriate reference of controller </returns>
        /// <exception cref="HttpException"> throws HttpException </exception>
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null && requestContext != null)
            {
                throw new HttpException(404, string.Format(CultureInfo.InvariantCulture, "The Windsor Controller at path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
            }

            return (IController)this.windsorKernel.Resolve(controllerType);
        }
    }
}