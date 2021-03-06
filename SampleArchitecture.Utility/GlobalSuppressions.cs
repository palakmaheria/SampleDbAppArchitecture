#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents global supressions class
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

//// This file is used by Code Analysis to maintain SuppressMessage 
//// attributes that are applied to this project.
//// Project-level suppressions either have no target or are given 
//// a specific target and scoped to a namespace, type, member, etc.
////
//// To add a suppression to this file, right-click the message in the 
//// Code Analysis results, point to "Suppress Message", and click 
//// "In Suppression File".
//// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RND", Scope = "type", Target = "SampleArchitecture.Data.RNDEntities", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "tbl", Scope = "member", Target = "SampleArchitecture.Data.RNDEntities.#tblUsers", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "tbl", Scope = "member", Target = "SampleArchitecture.Data.RNDEntities.#tblUsers", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "tbl", Scope = "type", Target = "SampleArchitecture.Data.tblUser", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "tbl", Scope = "type", Target = "SampleArchitecture.Data.tblUser", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dto", Scope = "type", Target = "SampleArchitecture.Mapper.Mapping.UserTableToUserDtoMapping", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dto", Scope = "type", Target = "SampleArchitecture.Model.UserDto", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "apiId", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.Controllers.HelpController.#Api(System.String)", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Service.Areas.HelpPage.Controllers", Justification = "Need to review.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Service.Areas.HelpPage.Models", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Service.Infrastructure", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Service.Controllers", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Mapper.Adapter", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Mapper.Repository", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Mapper.Mapping", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "SampleArchitecture.Mapper.Contracts", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.ApiDescriptionExtensions.#GetFriendlyId(System.Web.Http.Description.ApiDescription)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.BundleConfig.#RegisterBundles(System.Web.Optimization.BundleCollection)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.FilterConfig.#RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageAreaRegistration.#RegisterArea(System.Web.Mvc.AreaRegistrationContext)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageConfigurationExtensions.#SetDocumentationProvider(System.Web.Http.HttpConfiguration,System.Web.Http.Description.IDocumentationProvider)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageConfigurationExtensions.#GetHelpPageSampleGenerator(System.Web.Http.HttpConfiguration)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageConfigurationExtensions.#SetHelpPageSampleGenerator(System.Web.Http.HttpConfiguration,SampleArchitecture.Service.Areas.HelpPage.HelpPageSampleGenerator)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageConfigurationExtensions.#GetHelpPageApiModel(System.Web.Http.HttpConfiguration,System.String)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageSampleGenerator.#WriteSampleObjectUsingFormatter(System.Net.Http.Formatting.MediaTypeFormatter,System.Object,System.Type,System.Net.Http.Headers.MediaTypeHeaderValue)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "SampleArchitecture.Service.WebApiConfig.#Register(System.Web.Http.HttpConfiguration)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "config", Scope = "member", Target = "SampleArchitecture.Service.Areas.HelpPage.HelpPageConfig.#Register(System.Web.Http.HttpConfiguration)", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "SampleArchitecture.Mapper.Adapter.TypeMapConfigurationBase`2.#GetDescriptor()", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "SampleArchitecture.Mapper.Adapter.TypeMapConfigurationBase`2.#GetDescriptor()", Justification = "Supression is OK here.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Supression is OK here.")]
