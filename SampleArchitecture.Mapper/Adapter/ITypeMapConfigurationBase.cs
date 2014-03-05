#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ITypeMapConfigurationBase.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Contract for type map configuration base
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Mapper.Adapter
{
    /// <summary>
    /// Base contract type map configurations
    /// </summary>
    public interface ITypeMapConfigurationBase
    {
        /// <summary>
        /// Gets descriptor for this instance. 
        /// <remarks>
        /// This descriptor is not unique string.
        /// </remarks>
        /// </summary>
        string Descriptor { get; }
    }
}
