// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="Pist">
//   Pist copyrights 2014
// </copyright>
// <summary>
//   The user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.NativeDAL
{
    using System.ComponentModel;

    /// <summary>
    /// The user.
    /// </summary>
    public class tblUser : Entity<tblUser>
    {
        #region Table Fields

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
        [DisplayName("Identity")]
        [Category("Column")]
        [DataObjectFieldAttribute(true, true, false)]
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DisplayName("Name")]
        [Category("Column")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [DisplayName("Password")]
        [Category("Column")]
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        #endregion
    }
}
