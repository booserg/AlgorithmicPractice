using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Challenges.LongestBalancedString
{
	public class Solution
	{
		public int solution(string S)
		{
			if (S.Length <= 1)
				return 0;

			int longestBalanced = 0;
			
			CustomQueue queue = new CustomQueue();

			for (int i = 0; i < S.Length; i++)
			{
				queue.Push(S[i]);
				if (queue.GetCurrentLongest() > longestBalanced)
					longestBalanced = queue.GetCurrentLongest();
			}

			return longestBalanced;
		}

		class CustomQueue
		{
			public Element First { get; set; }
			public Element Second { get; set; }

			public void Push(char ch)
			{
				if (First == null)
				{
					First = new Element() { Ch = ch, Cnt = 1 };
					return;
				}

				if (First.Ch == ch)
					First.Cnt++;
				else if (Second == null)
				{
					Second = new Element() { Ch = ch, Cnt = 1 };
				}
				else if (Second.Ch == ch)
					Second.Cnt++;
				else
				{
					First = Second;
					Second = new Element() { Ch = ch, Cnt = 1 };
				}
			}

			public int GetCurrentLongest()
			{
				if(First != null && Second != null)
				{
					return Math.Min(First.Cnt, Second.Cnt) * 2;
				}
				return 0;
			}
		}

		class Element
		{
			public char Ch { get; set; }
			public int Cnt { get; set; }
		}
	}
}
