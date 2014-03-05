using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArchitecture.Repository.Repository
{
    using SampleArchitecture.Data;
    using SampleArchitecture.Model;
    using SampleArchitecture.Repository.Contract;

    public class UserRepository : IUserRepository
    {

        /// <summary>
        /// Declare variable for mapping Dto
        /// </summary>
        private ITypeAdapter languageTypeAdapter;

        ///// <summary>
        ///// Declare variable for mapping Dto
        ///// </summary>
        //private ITypeAdapter userTypeAdapter;

        UserDto GetUserById(long userId)
        {
            UserDto userDto = null;
            using (var entity = new RNDEntities())
            {
                //IQueryable<tblUser> users = getUserById.Invoke(qateEntity, userId, clientId);
                //if (users.Any())
                //{
                //    userDto = this.userTypeAdapter.Adapt<vw_QissUsers, UserDto>(users.SingleOrDefault());
                //}
            }

            return userDto;
        }
    }
}
