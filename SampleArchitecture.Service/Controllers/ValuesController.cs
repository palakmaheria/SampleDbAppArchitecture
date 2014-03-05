//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="ValuesController.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents values controller class
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Service.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using SampleArchitecture.Business.Contracts;
    using SampleArchitecture.Model;

    /// <summary>
    /// The values controller.
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// The user business.
        /// </summary>
        private readonly IUserBusiness userBusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// </summary>
        /// <param name="userBusiness">
        /// The user business.
        /// </param>
        public ValuesController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns> The <see cref="Enumerable"/>. </returns>
        //// GET api/values
        public IEnumerable<string> Get()
        {
            var response = this.userBusiness.GetUserDetailsById(1);
            if (response.Response != null)
            {
                return new[] { response.Response.Name, response.Response.Password };
            }

            return response.Error != null ? new[] { response.Error.Message, response.Error.StackTrace } : new[] { "unknown error", "unknown error" };
        }

        /// <summary> The get. </summary>
        /// <param name="id"> The id. </param>
        /// <returns> The <see cref="string"/>. </returns>
        //// GET api/values/5
        public string Get(int id)
        {
            var response = this.userBusiness.GetUserDetailsById(id);
            if (response.Response != null)
            {
                return response.Response.Name;
            }

            return response.Error != null ? response.Error.Message : "unknown error";
        }

        /// <summary> The post. </summary>
        /// <param name="value"> The value. </param>
        //// POST api/values
        public void Post([FromBody]UserDto value)
        {
            this.userBusiness.AddUser(value);
        }

        /////// <summary> The post. </summary>
        /////// <param name="value"> The value. </param>
        //////// POST api/values
        ////public void Post([FromBody]string value)
        ////{

        ////}

        /////// <summary> The put. </summary>
        /////// <param name="id"> The id. </param>
        /////// <param name="value"> The value. </param>
        //////// PUT api/values/5
        ////public void Put(int id, [FromBody]string value)
        ////{
        ////}

        /////// <summary> The delete. </summary>
        /////// <param name="id"> The id. </param>
        //////// DELETE api/values/5
        ////public void Delete(int id)
        ////{
        ////}
    }
}
