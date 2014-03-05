//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="BundleConfig.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents bundle config class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service
{
    using System.Web.Optimization;

    /// <summary>
    /// The bundle config.
    /// </summary>
    public static class BundleConfig
    {
        /// <summary>
        /// The register bundles.
        /// </summary>
        /// <param name="bundles"> The bundles. </param>
        //// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
