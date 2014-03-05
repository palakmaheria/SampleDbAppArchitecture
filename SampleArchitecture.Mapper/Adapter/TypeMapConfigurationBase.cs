//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="TypeMapConfigurationBase.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents type map configurations base class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Mapper.Adapter
{
    #region Namespaces

    using System.Globalization;

    #endregion Namespaces

    /// <summary>
    /// The type map configuration base. With this class
    /// you can specify the map for convert a source type into target type.
    /// This maps  supports before and after injection points.
    /// </summary>
    /// <typeparam name="TSource">The source </typeparam>
    /// <typeparam name="TTarget">The target type</typeparam>
    public abstract class TypeMapConfigurationBase<TSource, TTarget> : ITypeMapConfigurationBase
        where TSource : class
        where TTarget : class, new()
    {
        #region Members
        /// <summary>
        /// adapter key code
        /// </summary>
        private int? requestedHashCode = null;
        #endregion

        #region Properties
        /// <summary>
        /// Gets descriptor for this instance. 
        /// <remarks>
        /// This descriptor is not unique string.
        /// </remarks>
        /// </summary>
        public string Descriptor
        {
            get
            {
                return GetDescriptor();
            }
        }
        #endregion

        #region Public Static Methods

        /// <summary>
        /// Get MapSpec descriptor
        /// </summary>
        /// <returns>Associated descriptor</returns>
        public static string GetDescriptor()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}<->{1}", typeof(TSource).FullName, typeof(TTarget).FullName);
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// The resolver. Adapt a {TSource} instance into a new instance of type {TTarget}
        /// <remarks>
        /// This is the template method for translate a source type into a destination type. The template
        /// is BeforeMap -> Map -> AfterMap
        /// </remarks>
        /// </summary>
        /// <param name="source">The source item to adapt</param>
        /// <param name="moreSources">Nested data to use in pipeline</param>
        /// <returns>The target instance</returns>
        public TTarget Resolve(TSource source, params object[] moreSources)
        {
            ////execute prefilter
            this.BeforeMap(source);

            ////  map from source to target using conventions or specific things ( for each framework )
            var target = this.Map(source);

            ////execute postfilter
            this.AfterMap(target, moreSources);

            ////return adapted object
            return target;
        }

        #endregion

        #region Override Methods

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj"> Object equals. </param>
        /// <returns> The <see cref="bool"/>. </returns>
        public override bool Equals(object obj)
        {
            var isEqual = true;

            if (obj == null)
            {
                isEqual = false;
            }

            var mapConfigurationBase = obj as TypeMapConfigurationBase<TSource, TTarget>;

            if (mapConfigurationBase == null)
            {
                isEqual = false;
            }

            return isEqual;
        }

        /// <summary>
        /// get Adapter key code
        /// </summary>
        /// <returns>return Source and target has key code </returns>
        public override int GetHashCode()
        {
            if (!this.requestedHashCode.HasValue)
            {
                this.requestedHashCode = typeof(TSource).GetHashCode() ^ typeof(TTarget).GetHashCode() * 31;
            }

            return this.requestedHashCode.Value;
        }

        #endregion

        #region Abstract

        /// <summary>
        /// Executed action before map source to target.
        /// <remarks>
        /// If you use a framework for mappings you can use this method
        /// for preparing or setup the map.
        /// </remarks>
        /// </summary>
        /// <param name="source">The source to adapt</param>
        protected abstract void BeforeMap(TSource source);

        /// <summary>
        /// Executed action after map.
        /// <remarks>
        /// You can use this method to set more sources into adapted object
        /// </remarks>
        /// </summary>
        /// <param name="target">The item adapted </param>
        /// <param name="moreSources">Nested data to use in post filter</param>
        protected abstract void AfterMap(TTarget target, params object[] moreSources);

        /// <summary>
        /// Map a source to a target
        /// </summary>
        /// <remarks>
        /// If you use a framework, use this method for setup or resolve mapping.
        /// <example>Auto mapper.Map{TSource,KTarget}</example>
        /// </remarks>
        /// <param name="source">The source to map</param>
        /// <returns>A new instance of <typeparamref name="TTarget"/></returns>
        protected abstract TTarget Map(TSource source);
        #endregion
    }
}
