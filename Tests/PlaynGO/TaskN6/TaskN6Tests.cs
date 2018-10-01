using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN6;

namespace Tests.PlaynGO.TaskN6
{
	[TestClass]
	public class TaskN6Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = sln.solution("sdf");

			Assert.AreEqual(0, res);
		}
	}
}
