//// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Pist" file="UserDto.cs">
//   Copyright (c) 2014 Pist. All rights reserved.
// </copyright>
// <summary>
// Represents user data type object
// </summary>
//// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.Model
{
    /// <summary>
    /// The user data type object.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// The id.
        /// </summary>
        private int id;

        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        /// <summary>
        /// The password.
        /// </summary>
        private string password;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }
    }
}
