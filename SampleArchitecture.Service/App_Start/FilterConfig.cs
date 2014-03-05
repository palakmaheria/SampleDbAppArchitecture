//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="FilterConfig.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents filter config class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service
{
    using System.Web.Mvc;

    /// <summary>
    /// The filter config.
    /// </summary>
    public static class FilterConfig
    {
        /// <summary>
        /// The register global filters.
        /// </summary>
        /// <param name="filters">
        /// The filters.
        /// </param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
