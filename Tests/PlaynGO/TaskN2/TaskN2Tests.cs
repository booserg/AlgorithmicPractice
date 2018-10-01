using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN2;

namespace Tests.PlaynGO.TaskN2
{
	[TestClass]
	public class TaskN2Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = sln.solution(5.6789M);

			Assert.AreEqual(5.67M, res);
		}
	}
}
