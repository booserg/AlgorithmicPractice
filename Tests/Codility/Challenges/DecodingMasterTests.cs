using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Challenges.DecodingMaster;

namespace Tests.Codility.Challenges
{
	[TestClass]
	public class DecodingMasterTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 0 }, new int[] { 2, 3 });

			Assert.AreEqual(1, res);
		}


		[TestMethod]
		public void TestMethod2()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 0 }, new int[] { 2, 0 });

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod3()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 0 }, new int[] { 1, 0 });

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod4()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1 }, new int[] { 2 });

			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1 }, new int[] { 1 });

			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void TestMethod6()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 1, 2 }, new int[] { 1, 1, 2 });

			Assert.AreEqual(4, res);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 1, 1 }, new int[] { 1, 1, 2 });

			Assert.AreEqual(5, res);
		}

		[TestMethod]
		public void TestMethod8()
		{
			Solution sln = new Solution();
			int res = sln.solution(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 2, 2, 2 });

			Assert.AreEqual(6, res);
		}
	}
}
