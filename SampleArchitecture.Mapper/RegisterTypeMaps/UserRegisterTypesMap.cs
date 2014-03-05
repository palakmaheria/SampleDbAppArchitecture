//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="UserRegisterTypesMap.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents user register types map class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Mapper.RegisterTypeMaps
{
    using SampleArchitecture.Mapper.Adapter;
    using SampleArchitecture.Mapper.Mapping;

    /// <summary>
    /// The user register types map.
    /// </summary>
    internal class UserRegisterTypesMap : RegisterTypesMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegisterTypesMap"/> class.
        /// </summary>
        public UserRegisterTypesMap()
        {
            this.RegisterMap(new UserTableToUserDtoMapping());
            this.RegisterMap(new UserDtoToUserTableMapping());
        }
    }
}
