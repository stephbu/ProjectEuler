using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace ProjectEulerTests
{
    /// <summary>
    /// Summary description for Problem8Tests
    /// </summary>
    [TestClass]
    public class Problem8Tests
    {
        public Problem8Tests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Problem8SumChars()
        {
            Assert.AreEqual(24, Problem8.ProductChars("73167".ToCharArray()));
        }

        [TestMethod]
        public void Problem8Slice()
        {
            var input = "1000012345";
            var slices = input.Slice(5).ToArray();
            var max = slices.Max(slice => Problem8.ProductChars(slice));
            Assert.AreEqual(120, max);
            Assert.AreEqual(6, slices.Count());
        }

        [TestMethod]
        public void Answer()
        {
            Problem8.Answer();
        }
    }
}
