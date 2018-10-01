using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.PlaynGO.TaskN3;

namespace Tests.PlaynGO.TaskN3
{
	[TestClass]
	public class TaskN3Tests
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();

			var res = sln.solution(new[] { 8, 3, 9, 24, 16 });

			Assert.AreEqual(3, res);
		}
	}
}
