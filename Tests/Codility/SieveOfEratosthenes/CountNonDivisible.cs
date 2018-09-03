using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.SieveOfEratosthenes.CountNonDivisible;

namespace Tests.Codility.SieveOfEratosthenes
{
    [TestClass]
    public class CountNonDivisible
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();

            var res = sln.solution(new int[] { 3, 1, 2, 3, 6 });

            CollectionAssert.AreEqual(new[] { 2, 4, 3, 2, 0 }, res);
        }
    }
}
