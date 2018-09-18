using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmicPractice.Codility.Challenges.DecodingMaster2;

namespace Tests.Codility.Challenges
{
	[TestClass]
	public class DecodingMasterTests2
	{
		[TestMethod]
		public void TestMethod1()
		{
			Solution sln = new Solution();
			var res = sln.solution(new int[] { 1, 1 }, new int[] { 2, 2 });
		}
	}
}
