#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserBusiness.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Contract for user business
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Business.Contracts
{
    using SampleArchitecture.DataServiceProvider;
    using SampleArchitecture.Model;

    /// <summary>
    /// The User business interface.
    /// </summary>
    public interface IUserBusiness
    {
        /// <summary>
        /// The get user details by id.
        /// </summary>
        /// <param name="userId"> The user id. </param>
        /// <returns>Data service response of type user Dto </returns>
        DataServiceResponse<UserDto> GetUserDetailsById(int userId);

        /// <summary>
        /// The add user.
        /// </summary>
        /// <param name="user"> The user. </param>
        /// <returns> The data service response </returns>
        DataServiceResponse<int> AddUser(UserDto user);
    }
}
