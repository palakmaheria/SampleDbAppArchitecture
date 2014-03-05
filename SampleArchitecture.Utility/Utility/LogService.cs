#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="LogService.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents log service class
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Utility.Utility
{
    using System;

    /// <summary>
    /// The log service.
    /// </summary>
    public class LogService : ILogService
    {
        #region Implementation of ILogService

        /// <summary>
        /// Exception logging.
        /// </summary>
        /// <param name="exception"> Exception instance. </param>
        /// <param name="callerName"> The caller name. </param>
        /// <param name="callerFilePath"> The caller File Path. </param>
        /// <param name="callerLineNumber"> The caller Line Number. </param>
        public void LogException(Exception exception, string callerName, string callerFilePath, int callerLineNumber)
        {
        }

        /// <summary>
        /// Information logging.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public void LogMessage(string message)
        {
        }

        #endregion
    }
}
