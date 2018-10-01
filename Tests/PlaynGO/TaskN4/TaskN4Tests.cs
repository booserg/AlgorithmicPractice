using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN4;

namespace Tests.PlaynGO.TaskN4
{
	[TestClass]
	public class TaskN4Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = sln.solution(1234567.89M);

			Assert.AreEqual("1,234,567.89", res);
		}
	}
}
