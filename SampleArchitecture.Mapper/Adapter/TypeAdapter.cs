#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="TypeAdapter.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents type adapter class
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Mapper.Adapter
{
    #region Namespaces

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    #endregion Namespaces

    /// <summary>
    /// The type adapter.
    /// </summary>
    internal sealed class TypeAdapter : ITypeAdapter
    {
        /// <summary>
        /// MapConfigurationBase elements
        /// </summary>
        private Dictionary<string, ITypeMapConfigurationBase> mapConfigurationBase;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeAdapter"/> class.
        /// </summary>
        /// <param name="mapModules">
        /// The map modules.
        /// </param>
        public TypeAdapter(RegisterTypesMap[] mapModules)
        {
            this.InitializeAdapter(mapModules);
        }

        #endregion

        #region ITypeAdapter Implementation

        /// <summary>
        /// The adapt.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <typeparam name="TSource"> Type source </typeparam>
        /// <typeparam name="TTarget"> Type target </typeparam>
        /// <returns> The <see cref="TTarget"/>. </returns>
        /// <exception cref="ArgumentNullException">Argument null exception </exception> <exception cref="InvalidOperationException"> </exception>
        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, 
            new()
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            var descriptor = TypeMapConfigurationBase<TSource, TTarget>.GetDescriptor();

            if (!this.mapConfigurationBase.ContainsKey(descriptor))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Invalid Operation Exception {0}-{1}", typeof(TSource).FullName, typeof(TTarget).FullName));
            }

            var spec = this.mapConfigurationBase[descriptor] as TypeMapConfigurationBase<TSource, TTarget>;

            return spec.Resolve(source);
        }

        /// <summary>
        /// The adapt.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="moreSources"> The more sources. </param>
        /// <typeparam name="TSource">Source type </typeparam>
        /// <typeparam name="TTarget"> Target type</typeparam>
        /// <returns> The <see cref="TTarget"/>Returns target type </returns>
        /// <exception cref="ArgumentNullException">Argument null exception </exception>
        /// <exception cref="InvalidOperationException"> Invalid operation exception</exception>
        public TTarget Adapt<TSource, TTarget>(TSource source, params object[] moreSources)
            where TSource : class
            where TTarget : class, new()
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            var descriptor = TypeMapConfigurationBase<TSource, TTarget>.GetDescriptor();

            if (!this.mapConfigurationBase.ContainsKey(descriptor))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Invalid Operation Exception  {0}-{1}", typeof(TSource).FullName, typeof(TTarget).FullName));
            }

            var spec = this.mapConfigurationBase[descriptor] as TypeMapConfigurationBase<TSource, TTarget>;

            return spec.Resolve(source, moreSources);
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Initialize Adapter
        /// </summary>
        /// <param name="mapModules">register module name</param>
        private void InitializeAdapter(RegisterTypesMap[] mapModules)
        {
            ////  create map adapters dictionary
            this.mapConfigurationBase = new Dictionary<string, ITypeMapConfigurationBase>();

            if (mapModules == null)
            {
                return;
            }

            ////  foreach adapter's module in solution load mapping
            foreach (var map in mapModules.SelectMany(module => module.MapConfigurationBase))
            {
                this.mapConfigurationBase.Add(map.Key, map.Value);
            }
        }

        #endregion
    }
}
