using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.PlaynGO.TaskN1
{
	//Write a function that tests if a string is a palindrome (ie. if you get the same string if you reverse it).
	public class Solution
	{
		public bool solution(string str)
		{
			for (int i = 0; i < str.Length/2; i++)
			{
				if (str[i] != str[str.Length - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}
