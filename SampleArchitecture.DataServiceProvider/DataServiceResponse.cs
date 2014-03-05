#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="DataServiceResponse.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents data service response class
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.DataServiceProvider
{
    using System;

    /// <summary>
    /// The data service response.
    /// </summary>
    /// <typeparam name="T">Type of class </typeparam>
    public class DataServiceResponse<T>
    {
        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>The response.</value>
        public T Response
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        public Exception Error
        {
            get;
            set;
        }
    }
}
