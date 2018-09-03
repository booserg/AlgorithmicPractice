using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Challenges.King
{
    public class Solution
    {
		public int solution(int N, int M, int[] X, int[] Y)
		{
			var xLower = FindLowerBound(0, N, X);

			var xHigher = FindHigherBound(0, N, X);

			var yLower = FindLowerBound(0, M, Y);

			var yHigher = FindHigherBound(0, M, Y);

			var xDelta = 0;
			if (xLower > -1 && xHigher > -1)
				xDelta = xHigher - xLower + 1;

			var yDelta = 0;
			if (yLower > -1 && yHigher > -1)
				yDelta = yHigher - yLower + 1;

			return xDelta + yDelta;
		}

		static public int FindLowerBound(int startCoord, int endCoord, int[] arr)
		{
			var medium = (int)(startCoord + (endCoord - startCoord + 1) / 2);

			int lower = 0, higher = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < medium)
					lower++;
				else
					higher++;
			}

			if ((endCoord - startCoord) <= 2)
			{
				if (lower != higher)
					return -1;
				else
					return medium;
			}
			else
			{
				if (lower == higher && (medium - startCoord) <= 1)
				{
					return medium;
				}
				else
				{
					if (lower >= higher)
						return FindLowerBound(startCoord, medium, arr);
					else
						return FindLowerBound(medium, endCoord, arr); ;
				}
			}
		}

		static public int FindHigherBound(int startCoord, int endCoord, int[] arr)
		{
			var medium = (int)(startCoord + (endCoord - startCoord + 1) / 2);

			int lower = 0, higher = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < medium)
					lower++;
				else
					higher++;
			}

			if ((endCoord - startCoord) <= 2)
			{
				if (lower != higher)
					return -1;
				else
					return medium;
			}
			else
			{
				if (lower == higher && (endCoord - medium) <= 1)
				{
					return medium;
				}
				else
				{
					if (lower > higher)
						return FindHigherBound(startCoord, medium, arr);
					else
						return FindHigherBound(medium, endCoord, arr);
				}
			}
		}
	}
}
