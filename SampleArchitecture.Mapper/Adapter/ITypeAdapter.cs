#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ITypeAdapter.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Contract for type adapter
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Mapper.Adapter
{
    /// <summary>
    /// The TypeAdapter interface.
    /// </summary>
    public interface ITypeAdapter
    {
        /// <summary>
        /// Adapt a source object to an instance of type using
        /// nested object for map completion
        /// </summary>
        /// <typeparam name="TSource">Type of source item</typeparam>
        /// <typeparam name="TTarget">Type of target item</typeparam>
        /// <param name="source">Instance of source to map</param>
        /// <returns>Map source and target and returns target item</returns>
        TTarget Adapt<TSource, TTarget>(TSource source)
            where TTarget : class, new()
            where TSource : class;

        /// <summary>
        /// Adapt a source object to an instance of type using
        /// nested object for map completion
        /// </summary>
        /// <typeparam name="TSource">Type of source item</typeparam>
        /// <typeparam name="TTarget">Type of target item</typeparam>
        /// <param name="source">Instance of source to map</param>
        /// <param name="moreSources">More sources for mapping</param>
        /// <returns>Map source and target and returns target item</returns>
        TTarget Adapt<TSource, TTarget>(TSource source, params object[] moreSources)
            where TTarget : class,
            new()
            where TSource : class;
    }
}
