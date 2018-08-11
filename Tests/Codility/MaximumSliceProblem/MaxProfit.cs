using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.MaximumSliceProblem.MaxProfit;

namespace Tests.Codility.MaximumSliceProblem
{
    [TestClass]
    public class MaxProfit
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] {23171, 21011, 21123, 21366, 21013, 21367 });

            Assert.AreEqual<int>(356, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 1, 2, 1, 3, 1 });

            Assert.AreEqual<int>(2, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 1, 2, 1, 3, 3, 1 });

            Assert.AreEqual<int>(2, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 0, 3, 1, 2, 0 });

            Assert.AreEqual<int>(3, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 0, 1, 2, 3, 2 });

            Assert.AreEqual<int>(3, res);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 2, 3, 2, 1, 0 });

            Assert.AreEqual<int>(1, res);
        }
    }
}
