//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="UserTableToUserDtoMapping.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents user table to user Dto mapping
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Mapper.Mapping
{
    using AutoMapper;

    using SampleArchitecture.Data;
    using SampleArchitecture.Mapper.Adapter;
    using SampleArchitecture.Model;

    /// <summary>
    /// The user table to user dto mapping.
    /// </summary>
    public class UserTableToUserDtoMapping : TypeMapConfigurationBase<tblUser, UserDto>
    {
        #region Overrides of TypeMapConfigurationBase<tblUser,UserDto>

        /// <summary>
        /// Executed action before map source to target.
        /// <remarks>
        /// If you use a framework for mappings you can use this method
        /// for preparing or setup the map.
        /// </remarks>
        /// </summary>
        /// <param name="source">The source to adapt</param>
        protected override void BeforeMap(tblUser source)
        {
            Mapper.CreateMap<tblUser, UserDto>();
        }

        /// <summary>
        /// Executed action after map.
        /// <remarks> You can use this method to set more sources into adapted object </remarks>
        /// </summary>
        /// <param name="target">The item adapted </param>
        /// <param name="moreSources">Nested data to use in post filter</param>
        protected override void AfterMap(UserDto target, params object[] moreSources)
        {
        }

        /// <summary>
        /// The map.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <returns> The <see cref="UserDto"/>. </returns>
        protected override UserDto Map(tblUser source)
        {
            return Mapper.Map<tblUser, UserDto>(source);
        }

        #endregion
    }
}
