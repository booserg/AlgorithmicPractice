using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN1;

namespace Tests.PlaynGO.TaskN1
{
	[TestClass]
	public class TaskN1Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = sln.solution("sdf");

			Assert.AreEqual(false, res);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Solution sln = new Solution();

			var res = sln.solution("asa");

			Assert.AreEqual(true, res);
		}

		[TestMethod]
		public void TestMethod3()
		{
			Solution sln = new Solution();

			var res = sln.solution("asddsa");

			Assert.AreEqual(true, res);
		}

		[TestMethod]
		public void TestMethod4()
		{
			Solution sln = new Solution();

			var res = sln.solution("asdfsa");

			Assert.AreEqual(false, res);
		}

		[TestMethod]
		public void TestMethod5()
		{
			Solution sln = new Solution();

			var res = sln.solution("asdfdsa");

			Assert.AreEqual(true, res);
		}

		[TestMethod]
		public void TestMethod6()
		{
			Solution sln = new Solution();

			var res = sln.solution("asdffsa");

			Assert.AreEqual(false, res);
		}

		[TestMethod]
		public void TestMethod7()
		{
			Solution sln = new Solution();

			var res = sln.solution("a");

			Assert.AreEqual(true, res);
		}

		[TestMethod]
		public void TestMethod8()
		{
			Solution sln = new Solution();

			var res = sln.solution("");

			Assert.AreEqual(true, res);
		}
	}
}
