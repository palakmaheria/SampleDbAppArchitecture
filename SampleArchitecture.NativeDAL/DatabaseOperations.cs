// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseOperations.cs" company="Pist">
//   Pist copyrights 2014
// </copyright>
// <summary>
//   The database operations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.NativeDAL
{
    using System;
    using System.Data;

    /// <summary>
    /// The database operations.
    /// </summary>
    public static class DatabaseOperations
    {
        /// <summary>
        /// The execute non query.
        /// </summary>
        /// <param name="commandText"> The command text. </param>
        /// <returns> The <see cref="int"/>. </returns>
        public static int ExecuteNonQuery(string commandText)
        {
            try
            {
                using (var connectionFactory = new DatabaseConnection(DatabaseConnectionEnum.Sql))
                {
                    using (var connection = connectionFactory.GetConnection())
                    {
                        if (connection.State.Equals(ConnectionState.Open))
                        {
                            connection.Close();
                        }

                        connection.Open();
                        using (var command = connection.CreateCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = commandText;
                            command.CommandType = CommandType.Text;
                            return command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
