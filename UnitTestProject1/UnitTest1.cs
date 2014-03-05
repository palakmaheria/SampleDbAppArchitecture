// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Pist">
//   Pist copyrights 2014
// </copyright>
// <summary>
//   The unit test 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SampleArchitecture.Model;
    using SampleArchitecture.NativeDAL;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var test = new SampleArchitecture.NativeDAL.RNDEntities();
                ////var value = test.User.Add(new tblUser { Id = 5, Name = "hello", Password = "test" });
                var tlbuser = new tblUser { ID = 24, Name = "hello24", Password = "hello24" };
                var value = test.User.Add(tlbuser);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// The test method 2.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                var test = new SampleArchitecture.Mapper.Repository.UserRepository();
                var result = test.AddUser(new UserDto { Id = 10, Name = "test10", Password = "test10" });
            }
            catch (Exception)
            {
            }
        }
    }
}
