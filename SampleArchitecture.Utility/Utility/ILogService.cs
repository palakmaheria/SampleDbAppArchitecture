#region Copyright Pist
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogService.cs" company="Pist">
//     Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//      Represents log service interface
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace SampleArchitecture.Utility.Utility
{
    using System;

    /// <summary>
    /// The LogService interface.
    /// </summary>
    public interface ILogService
    {
        /// <summary>
        /// Exception logging.
        /// </summary>
        /// <param name="exception"> Exception instance. </param>
        /// <param name="callerName"> The caller name. </param>
        /// <param name="callerFilePath"> The caller File Path. </param>
        /// <param name="callerLineNumber"> The caller Line Number. </param>
        void LogException(Exception exception, string callerName, string callerFilePath, int callerLineNumber);

        /// <summary>
        /// Information logging.
        /// </summary>
        /// <param name="message">Message to log.</param>
        void LogMessage(string message);
    }
}
