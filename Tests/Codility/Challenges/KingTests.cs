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

			var res = Solution.FindBound(0, 5, new int[] { 0, 4 }, true, -1, false);

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 0, 4 }, false, -1, false);

			Assert.AreEqual(4, res);
		}

		[TestMethod]
		public void TestMethod3()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 3 }, true, -1, false);

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod4()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 3 }, false, -1, false);

			Assert.AreEqual(3, res);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 2 }, true, -1, false);

			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void TestMethod6()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 2 }, false, -1, false);

			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 2 }, true, -1, false);

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod8()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 2 }, false, -1, false);

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod9()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 2, 2 }, true, -1, false);

			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void TestMethod10()
		{
			Solution sln = new Solution();

			var res = Solution.FindBound(0, 5, new int[] { 1, 2, 2 }, false, -1, false);

			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void TestMethod11()
		{
			Solution sln = new Solution();

			var res = sln.solution(5, 5, new int[] { 0, 4, 2, 0 }, new int[] { 0, 0, 1, 4 });

			Assert.AreEqual(3, res);
		}
	}
}
