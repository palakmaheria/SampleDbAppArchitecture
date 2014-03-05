//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="IUserRepository.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents interface for user repository
// </summary>
//// --------------------------------------------------------------------------------------------------------------------
namespace SampleArchitecture.Mapper.Contracts
{
    using SampleArchitecture.Model;

    /// <summary>
    /// The UserRepository interface.
    /// </summary>
    public interface IUserRepository
    {       
        /// <summary>
        /// Get User entity by user Id.
        /// </summary>
        /// <param name="userId">user Id of user</param>
        /// <returns>Return user object.</returns>
        UserDto GetUserById(int userId);

        /// <summary>
        /// The add user.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int AddUser(UserDto user);
    }
}
