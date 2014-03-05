// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Entity.cs" company="Pist">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
//   The entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.NativeDAL
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// The entity.
    /// </summary>
    /// <typeparam name="T">Type of parameter </typeparam>
    public class Entity<T>
    {
        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <returns> The <see cref="int"/>. </returns>
        public int Add(T entity)
        {
            var commandText = PrepareInsertCommand(entity);
            return DatabaseOperations.ExecuteNonQuery(commandText);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <returns> The <see cref="int"/>. </returns>
        public int Update(T entity)
        {
            var commandText = PrepareUpdateCommand(entity);
            return DatabaseOperations.ExecuteNonQuery(commandText);
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <returns> The <see cref="int"/>. </returns>
        public int Delete(T entity)
        {
            return 0;
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone()
        {
            return null;
        }

        /// <summary>
        /// Gets the entity name.
        /// </summary>
        /// <param name="entity"> The entity.  </param>
        /// <returns> The <see cref="string"/>. </returns>
        private static string GetEntityName(string entity)
        {
            var entityName = entity.Split('.');
            return entityName[entityName.Length - 1];
        }

        /// <summary>
        /// The insert command.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <typeparam name="TC"> Type of parameter</typeparam>
        /// <returns> The <see cref="string"/>. </returns>
        private static string PrepareInsertCommand<TC>(TC entity)
        {
            var insert = string.Format(CultureInfo.InvariantCulture, Settings.InsertStatementToken, GetEntityName(entity.ToString()));
            var columns = Settings.OpeningBracket;
            var values = Settings.ValuesToken;
            var infos = GetInfo(entity);

            foreach (var item in infos.Where(item => item.Value != null && !string.IsNullOrEmpty(item.Value.ToString())))
            {
                columns += string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}", Settings.DoubleQuoationMark, item.Key, Settings.DoubleQuoationMark, Settings.Comma);
                values += string.Format(CultureInfo.InvariantCulture, "{0}{1}", Formatting(item.Value.ToString()), Settings.Comma);
            }

            columns = string.Format(CultureInfo.InvariantCulture, "{0}{1} ", columns.Remove(columns.Length - 1, 1), Settings.ClosingBracket);
            values = string.Format(CultureInfo.InvariantCulture, "{0}{1} ", values.Remove(values.Length - 1, 1), Settings.ClosingBracket);
            insert += string.Format(CultureInfo.InvariantCulture, "{0}{1}", columns, values);
            return insert;
        }

        /// <summary>
        /// The insert command.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <typeparam name="TY"> Type of parameter</typeparam>
        /// <returns> The <see cref="string"/>. </returns>
        private static string PrepareUpdateCommand<TY>(TY entity)
        {
            var update = string.Format(CultureInfo.InvariantCulture, Settings.UpdateStatementToken, GetEntityName(entity.ToString()));
            var infos = GetInfo(entity);
            update = infos.Where(item => item.Value != null && !string.IsNullOrEmpty(item.Value.ToString())).Aggregate(update, (current, item) => current + string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}={3},", Settings.DoubleQuoationMark, item.Key, Settings.DoubleQuoationMark, Formatting(item.Value.ToString())));

            update = update.Remove(update.Length - 1, 1) + " ";
            var primaryKeys = GetPrimaryKeysCollection(entity);

            update += string.Format(CultureInfo.InvariantCulture, "{0} {1}{2}{3}={4} ", Settings.WhereToken, Settings.DoubleQuoationMark, primaryKeys.First().Key, Settings.DoubleQuoationMark, Formatting(primaryKeys.First().Value.ToString()));
            return primaryKeys.Aggregate(update, (current, keyValuePair) => current + string.Format(CultureInfo.InvariantCulture, " {0} {1}{2}{3}={4}", Settings.AndToken, Settings.DoubleQuoationMark, keyValuePair.Key, Settings.DoubleQuoationMark, Formatting(keyValuePair.Value.ToString())));
        }

        /// <summary>
        /// The insert command.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <typeparam name="TX"> Type of parameter</typeparam>
        /// <returns> The <see cref="string"/>. </returns>
        private static string PrepareDeleteCommand<TX>(TX entity)
        {
            //// TODO: Implementation of this method is remaing
            return string.Empty;
        }

        /// <summary>
        /// The get info.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <typeparam name="TB"> Type of parameter</typeparam> 
        /// <returns> The Entity information </returns>
        private static Dictionary<string, object> GetInfo<TB>(TB entity)
        {
            try
            {
                var memberInfos = entity.GetType().GetProperties().Where(item => item.MemberType == MemberTypes.Property);
                return memberInfos.ToDictionary(memberInfo => memberInfo.Name, memberInfo => memberInfo.GetValue(entity, null));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /////// <summary>
        /////// The get info.
        /////// </summary>
        /////// <param name="entity"> The entity. </param>
        /////// <typeparam name="TB"> Type of parameter</typeparam> 
        /////// <returns> The Entity information </returns>
        ////private static Dictionary<string, object> GetInfo<TB>(TB entity)
        ////{
        ////    try
        ////    {
        ////        var values = new Dictionary<string, object>();

        ////        var memberInfos = entity.GetType().GetProperties().Where(item => item.MemberType == MemberTypes.Property);
        ////        var isPrimaryKey = false;
        ////        foreach (var memberInfo in memberInfos)
        ////        {
        ////            var attributes = memberInfo.GetCustomAttributes(typeof(DataObjectFieldAttribute), true);
        ////            foreach (var dataObjectFiedlAttribute in attributes.OfType<DataObjectFieldAttribute>().Where(dataObjectFiedlAttribute => dataObjectFiedlAttribute.PrimaryKey))
        ////            {
        ////                isPrimaryKey = true;
        ////            }

        ////            if (!isPrimaryKey)
        ////            {
        ////                values.Add(memberInfo.Name, memberInfo.GetValue(entity, null));
        ////            }

        ////            isPrimaryKey = false;
        ////        }

        ////        return values;
        ////    }
        ////    catch (Exception)
        ////    {
        ////        return null;
        ////    }
        ////}

        /// <summary>
        /// The get primary keys collection.
        /// </summary>
        /// <param name="entity"> The entity. </param>
        /// <typeparam name="TA"> Type of parameter</typeparam> 
        /// <returns> The Entity information </returns>
        private static Dictionary<string, object> GetPrimaryKeysCollection<TA>(TA entity)
        {
            try
            {
                var memberInfos = entity.GetType().GetProperties().Where(item => item.MemberType == MemberTypes.Property);
                return (from memberInfo in memberInfos
                        let attributes = memberInfo.GetCustomAttributes(typeof(DataObjectFieldAttribute), true)
                        from dataObjectFiedlAttribute in
                            attributes.OfType<DataObjectFieldAttribute>()
                            .Where(dataObjectFiedlAttribute => dataObjectFiedlAttribute.PrimaryKey)
                        select memberInfo).ToDictionary(
                            memberInfo => memberInfo.Name,
                            memberInfo => memberInfo.GetValue(entity, null));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// The formatting.
        /// </summary>
        /// <param name="item"> The item. </param>
        /// <returns> The <see cref="string"/>. </returns>
        private static string Formatting(string item)
        {
            bool r1 = false;
            Int32 r2 = 0;
            if (bool.TryParse(item, out r1) || Int32.TryParse(item, out r2))
            {
                return item;
            }

            return "'" + item + "'";
        }
    }
}
