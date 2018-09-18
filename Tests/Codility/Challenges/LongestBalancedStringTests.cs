using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Challenges.LongestBalancedString;

namespace Tests.Codility.Challenges
{
	[TestClass]
	public class LongestBalancedStringTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();
			var i = sln.solution("aa");

			Assert.AreEqual(0, i);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Solution sln = new Solution();
			var i = sln.solution("ab");

			Assert.AreEqual(2, i);
		}

		[TestMethod]
		public void TestMethod3()
		{
			Solution sln = new Solution();
			var i = sln.solution("cabbacc");

			Assert.AreEqual(4, i);
		}

		[TestMethod]
		public void TestMethod4()
		{
			Solution sln = new Solution();
			var i = sln.solution("abababa");

			Assert.AreEqual(6, i);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Solution sln = new Solution();
			var i = sln.solution("aaaaaaa");

			Assert.AreEqual(0, i);
		}

		[TestMethod]
		public void TestMethod6()
		{
			Solution sln = new Solution();
			var i = sln.solution("aaaabbb");

			Assert.AreEqual(6, i);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();
			var i = sln.solution("aaaaaaaaaabbaabbaabbaaaaaaaabb");

			Assert.AreEqual(16, i);
		}
	}
}
