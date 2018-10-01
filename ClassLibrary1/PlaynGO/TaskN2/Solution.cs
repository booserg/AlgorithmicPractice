using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.PlaynGO.TaskN2
{
	public class Solution
	{
		//Write a function that takes a decimal number, converts it to have at most 2 decimals, and returns the new value as a number. No rounding should happen, so 5.6789 would become 5.67.
		public decimal solution(decimal S)
		{
			var multypliedBy100 = (int)(S * 100);

			var res = ((decimal)multypliedBy100) / 100;

			return res;
		}
	}
}
