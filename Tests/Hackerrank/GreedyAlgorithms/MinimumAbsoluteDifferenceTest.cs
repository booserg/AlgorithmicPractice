using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Hackerrank.GreedyAlgorithms;

namespace Tests.Hackerrank.GreedyAlgorithms
{
    [TestClass]
    public class MinimumAbsoluteDifferenceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = MinimumAbsoluteDifference.minimumAbsoluteDifference(new int[] { 3, -7, 0 });

            Assert.AreEqual<int>(3, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var res = MinimumAbsoluteDifference.minimumAbsoluteDifference(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 });

            Assert.AreEqual<int>(1, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var res = MinimumAbsoluteDifference.minimumAbsoluteDifference(new int[] { 1, -3, 71, 68, 17 });

            Assert.AreEqual<int>(3, res);
        }
    }
}
