//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="HelpController.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   Represents help controller
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Areas.HelpPage.Controllers
{
    using System.Web.Http;
    using System.Web.Mvc;

    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HelpController"/> class.
        /// </summary>
        public HelpController() : this(GlobalConfiguration.Configuration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HelpController"/> class.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public HelpController(HttpConfiguration config)
        {
            this.Configuration = config;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        public HttpConfiguration Configuration { get; private set; }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            ViewBag.DocumentationProvider = this.Configuration.Services.GetDocumentationProvider();
            return this.View(this.Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        /// <summary>
        /// The api.
        /// </summary>
        /// <param name="apiId"> The api id. </param>
        /// <returns> The <see cref="ActionResult"/>. </returns>
        public ActionResult Api(string apiId)
        {
            if (!string.IsNullOrEmpty(apiId))
            {
                var apiModel = this.Configuration.GetHelpPageApiModel(apiId);
                if (apiModel != null)
                {
                    return this.View(apiModel);
                }
            }

            return this.View("Error");
        }
    }
}