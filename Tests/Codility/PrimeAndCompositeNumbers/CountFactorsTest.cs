using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.PrimeAndCompositeNumbers.CountFactors;

namespace Tests.Codility.PrimeAndCompositeNumbers
{
    [TestClass]
    public class CountFactorsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();

            var res = sln.solution(24);

            Assert.AreEqual<int>(8, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Solution sln = new Solution();

            var res = sln.solution(9);

            Assert.AreEqual<int>(3, res);
        }
    }
}
