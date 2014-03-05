// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RNDEntities.cs" company="Pist">
//   Pist copyrights 2014
// </copyright>
// <summary>
//   The rnd entities.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleArchitecture.NativeDAL
{
    /// <summary>
    /// The rnd entities.
    /// </summary>
    public class RNDEntities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RNDEntities"/> class.
        /// </summary>
        public RNDEntities()
        {
            this.User = new tblUser();
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public tblUser User { get; set; }
    }
}
