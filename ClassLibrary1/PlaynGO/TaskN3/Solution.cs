using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.PlaynGO.TaskN3
{
	//Create a function that takes an array of numbers as a parameter and returns the number of values that are a multiplier of ether 4 or 6 (or, of course, both).
	public class Solution
	{
		public int solution(int[] numbers)
		{
			var devisibleNumbersCnt = 0;
			foreach (var number in numbers)
			{
				if (number % 4 == 0 || number % 6 == 0)
				{
					devisibleNumbersCnt++;
				}
			}

			return devisibleNumbersCnt;
		}
	}
}
