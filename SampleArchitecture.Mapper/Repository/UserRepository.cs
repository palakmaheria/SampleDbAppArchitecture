//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="UserRepository.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   Represents user repository
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Mapper.Repository
{
    using System.Linq;

    using SampleArchitecture.Data;
    using SampleArchitecture.Mapper.Adapter;
    using SampleArchitecture.Mapper.Contracts;
    using SampleArchitecture.Mapper.RegisterTypeMaps;
    using SampleArchitecture.Model;
    using SampleArchitecture.NativeDAL;

    /// <summary>
    /// The user repository.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Declare variable for mapping Dto
        /// </summary>
        private ITypeAdapter userTypeAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        public UserRepository()
        {
            this.PrepareTypeAdapter();
        }

        /// <summary>
        /// The get user by id.
        /// </summary>
        /// <param name="userId"> The user id. </param>
        /// <returns> The <see cref="UserDto"/>. </returns>
        public UserDto GetUserById(int userId)
        {
            UserDto userDto;
            using (var rndEntity = new Data.RNDEntities())
            {
                var user = rndEntity.tblUsers.FirstOrDefault(item => item.Id.Equals(userId));
                userDto = this.userTypeAdapter.Adapt<Data.tblUser, UserDto>(user);
            }

            return userDto;
        }

        /// <summary>
        /// The add user.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int AddUser(UserDto user)
        {
            var rnd = new NativeDAL.RNDEntities();
            var tbluser = this.userTypeAdapter.Adapt<UserDto, NativeDAL.tblUser>(user);
            var result = rnd.User.Add(tbluser);
            return result;
        }

        /// <summary>
        /// Map Dto with entity objects
        /// </summary>
        private void PrepareTypeAdapter()
        {
            this.userTypeAdapter = new TypeAdapter(new RegisterTypesMap[] { new UserRegisterTypesMap() });
        }
    }
}
