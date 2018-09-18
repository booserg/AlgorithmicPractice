using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Fromsomewhere.Fibonacci;

namespace Tests.Fromsomewhere.Fibonacci
{
	[TestClass]
	public class FibonacciTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			int res = Solution.solution(0);

			Assert.AreEqual(res, 0);
		}

		[TestMethod]
		public void TestMethod2()
		{
			int res = Solution.solution(1);

			Assert.AreEqual(res, 1);
		}

		[TestMethod]
		public void TestMethod3()
		{
			int res = Solution.solution(2);

			Assert.AreEqual(res, 1);
		}

		[TestMethod]
		public void TestMethod4()
		{
			int res = Solution.solution(3);

			Assert.AreEqual(res, 2);
		}

		[TestMethod]
		public void TestMethod5()
		{
			int res = Solution.solution(4);

			Assert.AreEqual(res, 3);
		}

		[TestMethod]
		public void TestMethod6()
		{
			int res = Solution.solution(5);

			Assert.AreEqual(res, 5);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();
			int res = Solution.solution(6);

			Assert.AreEqual(res, 8);
		}

		[TestMethod]
		public void TestMethod8()
		{
			Solution sln = new Solution();
			int res = Solution.solution(11);

			Assert.AreEqual(res, 89);
		}
	}
}
