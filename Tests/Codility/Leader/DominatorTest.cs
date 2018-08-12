using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Leader.Dominator;

namespace Tests.Codility.Leader
{
    [TestClass]
    public class DominatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 });

            Assert.AreEqual<int>(7, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3, 4, 3, 2, 3, -1, 3 });

            Assert.AreEqual<int>(6, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3, 3, 3, 3, 1, 1, 1 });

            Assert.AreEqual<int>(3, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3,  1 });

            Assert.AreEqual<int>(-1, res);
        }
    }
}
