using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Challenges.King;

namespace Tests.Codility.Challenges
{
	[TestClass]
	public class KingTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = Solution.FindLowerBound(0, 5, new int[] { 0, 4, 2, 0 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Solution sln = new Solution();

			var res = Solution.FindLowerBound(0, 5, new int[] { 0, 0, 1, 4 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod3()
		{
			Solution sln = new Solution();

			var res = Solution.FindHigherBound(0, 5, new int[] { 0, 4, 2, 0 });

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod4()
		{
			Solution sln = new Solution();

			var res = Solution.FindHigherBound(0, 5, new int[] { 0, 0, 1, 4 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Solution sln = new Solution();

			var res = Solution.FindHigherBound(0, 5, new int[] { 0, 0 });

			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void TestMethod6()
		{
			Solution sln = new Solution();

			var res = Solution.FindHigherBound(0, 5, new int[] { 0, 4 });

			Assert.AreEqual(4, res);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();

			var res = Solution.FindLowerBound(0, 5, new int[] { 0, 4 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod9()
		{
			Solution sln = new Solution();

			var res = Solution.FindLowerBound(0, 5, new int[] { 0, 4 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod10()
		{
			Solution sln = new Solution();

			var res = sln.solution(5, 5, new int[] { 0, 4, 2, 0 }, new int[] { 0, 0, 1, 4 });

			Assert.AreEqual(3, res);
		}

		[TestMethod]
		public void TestMethod11()
		{
			Solution sln = new Solution();

			var res = sln.solution(1, 1, new int[] { 0 }, new int[] { 0 });

			Assert.AreEqual(0, res);
		}

		[TestMethod]
		public void TestMethod12()
		{
			Solution sln = new Solution();

			var res = sln.solution(5, 5, new int[] { 0, 0 }, new int[] { 0, 1 });

			Assert.AreEqual(1, res);
		}
	}
}
