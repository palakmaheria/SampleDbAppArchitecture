#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterTypesMap.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents retigster types map
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Mapper.Adapter
{
    #region Namespaces

    using System;
    using System.Collections.Generic;

    #endregion Namespaces

    /// <summary>
    /// The register types map.
    /// </summary>
    internal class RegisterTypesMap
    {
        /// <summary>
        /// store mapping object configuration
        /// </summary>
        private readonly Dictionary<string, ITypeMapConfigurationBase> typeMapConfigurationBase;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterTypesMap"/> class.
        /// </summary>
        protected RegisterTypesMap()
        {
            ////create a new instance of type maps dictionary
            this.typeMapConfigurationBase = new Dictionary<string, ITypeMapConfigurationBase>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the dictionary of type maps
        /// </summary>
        public Dictionary<string, ITypeMapConfigurationBase> MapConfigurationBase
        {
            get
            {
                return this.typeMapConfigurationBase;
            }
        }

        #endregion

        #region Public Abstract Methods

        /// <summary>
        /// The register map.
        /// </summary>
        /// <param name="mapConfigurationBase"> The map configuration base. </param>
        /// <typeparam name="TSource">Source type </typeparam>
        /// <typeparam name="TTarget">Target type </typeparam>
        /// <exception cref="ArgumentNullException">Argument null exception </exception>
        protected void RegisterMap<TSource, TTarget>(TypeMapConfigurationBase<TSource, TTarget> mapConfigurationBase)
            where TSource : class
            where TTarget : class,
            new()
        {
            if (mapConfigurationBase != null)
            {
                this.typeMapConfigurationBase.Add(mapConfigurationBase.Descriptor, mapConfigurationBase);
            }
            else
            {
                throw new ArgumentNullException("mapConfigurationBase");
            }
        }

        #endregion
    }
}
