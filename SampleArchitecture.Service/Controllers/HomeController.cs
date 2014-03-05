//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="HomeController.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents home controller
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns> The <see cref="ActionResult"/>. </returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return this.View();
        }
    }
}
