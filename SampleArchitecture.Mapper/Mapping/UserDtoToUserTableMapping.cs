// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDtoToUserTableMapping.cs" company="Pist">
//   Pist copyrights 2014
// </copyright>
// <summary>
//   The user table to user dto mapping.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Mapper.Mapping
{
    using SampleArchitecture.Mapper.Adapter;
    using SampleArchitecture.Model;

    /// <summary>
    /// The user table to user dto mapping.
    /// </summary>
    public class UserDtoToUserTableMapping : TypeMapConfigurationBase<UserDto, NativeDAL.tblUser>
    {
        #region Overrides of TypeMapConfigurationBase<UserDto,tblUser>

        /// <summary>
        /// Executed action before map source to target.
        /// <remarks>
        /// If you use a framework for mappings you can use this method
        /// for preparing or setup the map.
        /// </remarks>
        /// </summary>
        /// <param name="source">The source to adapt</param>
        protected override void BeforeMap(UserDto source)
        {
            AutoMapper.Mapper.CreateMap<UserDto, NativeDAL.tblUser>();
        }

        /// <summary>
        /// Executed action after map.
        /// <remarks>
        /// You can use this method to set more sources into adapted object
        /// </remarks>
        /// </summary>
        /// <param name="target">The item adapted </param>
        /// <param name="moreSources">Nested data to use in post filter</param>
        protected override void AfterMap(NativeDAL.tblUser target, params object[] moreSources)
        {
        }

        /// <summary>
        /// Map a source to a target
        /// </summary>
        /// <remarks>
        /// If you use a framework, use this method for setup or resolve mapping.
        /// <example>Auto mapper.Map{TSource,KTarget}</example>
        /// </remarks>
        /// <param name="source">The source to map</param>
        /// <returns>A new instance of <typeparamref name="TTarget"/></returns>
        protected override NativeDAL.tblUser Map(UserDto source)
        {
            return AutoMapper.Mapper.Map<UserDto, NativeDAL.tblUser>(source);
        }

        #endregion
    }
}
