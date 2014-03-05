#region Copyright Pist
//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="TypeMapConfiguration.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents type map configuration
// </summary>
//// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Mapper.Adapter
{
    #region Namespaces

    using System;

    #endregion Namespaces

    /// <summary>
    /// The type map configuration.
    /// </summary>
    /// <typeparam name="TSource"> Type of source</typeparam>
    /// <typeparam name="TTarget"> Type of target</typeparam>
    public sealed class TypeMapConfiguration<TSource, TTarget>
        : TypeMapConfigurationBase<TSource, TTarget>
        where TSource : class
        where TTarget : class, new()
    {
        #region Variable declaration
        /// <summary>
        /// before map action object use for any action 
        /// </summary>
        private Action<TSource> beforeMapActions = null;

        /// <summary>
        /// store map object
        /// </summary>
        private Func<TSource, TTarget> mapFunctions = null;

        /// <summary>
        /// after map action object use for any action 
        /// </summary>
        private Action<TTarget, object[]> afterMapActions = null;

        #endregion

        #region Public Methods

        /// <summary>
        /// The before.
        /// </summary>
        /// <param name="beforeMapAction"> The before map action. </param>
        /// <returns> The type map configuration </returns>
        public TypeMapConfiguration<TSource, TTarget> Before(Action<TSource> beforeMapAction)
        {
            this.beforeMapActions = beforeMapAction;
            return this;
        }

        /// <summary>
        /// Configure map function
        /// </summary>
        /// <param name="mapFunction">The map function to use</param>
        /// <returns>Instance of this class</returns>
        public TypeMapConfiguration<TSource, TTarget> Map(Func<TSource, TTarget> mapFunction)
        {
            this.mapFunctions = mapFunction;
            return this;
        }

        /// <summary>
        /// Configure the after map action
        /// </summary>
        /// <param name="afterMapAction">The post function</param>
        /// <returns>Instance of this class</returns>
        public TypeMapConfiguration<TSource, TTarget> After(Action<TTarget, object[]> afterMapAction)
        {
            this.afterMapActions = afterMapAction;
            return this;
        }

        #endregion

        #region TypeMapConfigurationBase Members

        /// <summary>
        /// method will invoke before Mapping target object
        /// </summary>
        /// <param name="source">source object</param>
        protected override void BeforeMap(TSource source)
        {
            ////  call to before map action
            if (this.beforeMapActions != null)
            {
                this.beforeMapActions(source);
            }
        }

        /// <summary>
        /// method will invoke after Mapping target object
        /// </summary>
        /// <param name="target"> The target. </param>
        /// <param name="moreSources"> The more Sources. </param>
        protected override void AfterMap(TTarget target, params object[] moreSources)
        {
            ////  call to after map action
            if (this.afterMapActions != null)
            {
                this.afterMapActions(target, moreSources);
            }
        }

        /// <summary>
        /// method will invoke after Mapping target object
        /// </summary>
        /// <param name="source"> source object </param>
        /// <returns> The <see cref="TTarget"/>. </returns>
        protected override TTarget Map(TSource source)
        {
            if (this.mapFunctions != null)
            {
                return this.mapFunctions(source);
            }

            throw new InvalidOperationException("Map is not specified");
        }

        #endregion
    }
}
