using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using ProjectEuler;

namespace ProjectEulerTests
{
    [TestClass]
    public class LongExtensionTests
    {
        [TestMethod]
        public void VerifyFactors()
        {
            Assert.IsTrue(1L.Factors().OrderBy(var => var).SequenceEqual(new[]{1L}));
            Assert.IsTrue(2L.Factors().OrderBy(var => var).SequenceEqual(new[] { 1L,2L }));
            Assert.IsTrue(3L.Factors().OrderBy(var => var).SequenceEqual(new[] { 1L, 3L }));
            Assert.IsTrue(4L.Factors().OrderBy(var => var).SequenceEqual(new[] { 1L, 2L, 4L }));
            Assert.IsTrue(24L.Factors().OrderBy(var => var).SequenceEqual(new[] { 1L, 2L, 3L, 4L, 6L, 8L, 12L, 24L }));
        }
    }
}
