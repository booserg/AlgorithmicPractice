using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN5;

namespace Tests.PlaynGO.TaskN5
{
	[TestClass]
	public class TaskN5Tests
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
