using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Leader.Dominator;

namespace Tests.Codility.Leader
{
    [TestClass]
    public class Dominator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 });

            Assert.AreEqual<int>(3, res);
        }
    }
}
