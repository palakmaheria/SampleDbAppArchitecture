//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="UserBusiness.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents user business layer class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Business.Business
{
    using System;
    using SampleArchitecture.Business.Contracts;
    using SampleArchitecture.DataServiceProvider;
    using SampleArchitecture.Mapper.Contracts;
    using SampleArchitecture.Model;

    /// <summary>
    /// The user business.
    /// </summary>
    public class UserBusiness : IUserBusiness
    {
        /// <summary>
        /// The user repository.
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBusiness"/> class.
        /// </summary>
        /// <param name="userRepository">
        /// The user repository.
        /// </param>
        /// <exception cref="ArgumentNullException"> Argument null exception</exception>
        public UserBusiness(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new ArgumentNullException("userRepository");
            }

            this.userRepository = userRepository;
        }

        #region Implementation of IUserBusiness

        /// <summary>
        /// Get User details by User Id.
        /// </summary>
        /// <param name="userId"> User Id. </param>
        /// <returns> User details. </returns>
        public DataServiceResponse<UserDto> GetUserDetailsById(int userId)
        {
            var responseUserDto = new DataServiceResponse<UserDto>();
            try
            {
                responseUserDto.Response = this.userRepository.GetUserById(userId);
                responseUserDto.Error = null;
            }
            catch (NullReferenceException nullReferenceException)
            {
                responseUserDto.Response = null;
                responseUserDto.Error = nullReferenceException;
            }

            return responseUserDto;
        }

        /// <summary>
        /// The add user.
        /// </summary>
        /// <param name="user"> The user. </param>
        /// <returns> The data service response </returns>
        public DataServiceResponse<int> AddUser(UserDto user)
        {
            var responseUserDto = new DataServiceResponse<int>();
            try
            {
                responseUserDto.Response = this.userRepository.AddUser(user);
                responseUserDto.Error = null;
            }
            catch (NullReferenceException nullReferenceException)
            {
                responseUserDto.Response = 0;
                responseUserDto.Error = nullReferenceException;
            }

            return responseUserDto;
        }

        #endregion
    }
}
