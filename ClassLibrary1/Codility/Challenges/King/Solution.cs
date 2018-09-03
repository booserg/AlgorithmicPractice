using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Challenges.King
{
    public class Solution
    {
		public int solution(int N, int M, int[] X, int[] Y)
		{
			var xLower = FindBound(0, N, X, true, -1, false);

			var xHigher = FindBound(0, N, X, false, -1, false);

			var yLower = FindBound(0, M, Y, true, -1, false);

			var yHigher = FindBound(0, M, Y, false, -1, false);

			var xDelta = 0;
			if (xLower > -1 && xHigher > -1)
				xDelta = xHigher - xLower + 1;

			var yDelta = 0;
			if (yLower > -1 && yHigher > -1)
				yDelta = yHigher - yLower + 1;

			return xDelta + yDelta;
		}

		static public int FindBound(int startCoord, int endCoord, int[] arr, bool areGoingDown, int lastMedium, bool isSuccessful)
		{
			var medium = (int)(startCoord + (endCoord - startCoord + ((areGoingDown)?1:0)) / 2);

			int lower = 0, higher = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < medium)
					lower++;
				else
					higher++;
			}

			if(lastMedium == medium)
			{
				if (lower == higher)
					return medium;
				else if (isSuccessful)
					return lastMedium;
				else
					return -1;
			}
			else
			{
				lastMedium = medium;
				isSuccessful = lower == higher;

				if (areGoingDown)
				{
					if(lower == higher)
						return FindBound(startCoord, medium, arr, true, lastMedium, isSuccessful);
					else if (lower > higher)
						return FindBound(startCoord, medium, arr, true, lastMedium, isSuccessful);
					else
						return FindBound(medium, endCoord, arr, true, lastMedium, isSuccessful);
				}
				else
				{
					if(higher == lower)
						return FindBound(medium, endCoord, arr, false, lastMedium, isSuccessful);
					else if (higher > lower)
						return FindBound(medium, endCoord, arr, false, lastMedium, isSuccessful);
					else
						return FindBound(startCoord, medium, arr, false, lastMedium, isSuccessful);
				}
			}

			//if ((endCoord - startCoord) <= 2)
			//{
			//	if (lower != higher)
			//		return -1;
			//	else
			//		return medium;
			//}
			//else
			//{
			//	if (lower == higher && isFound(startCoord, medium, endCoord) <= 1)//(medium - startCoord)
			//	{
			//		return medium;
			//	}
			//	else
			//	{
			//		if (approchSide(lower, higher))// lower >= higher
			//			return FindBound(startCoord, medium, arr, approchSide, isFound);
			//		else
			//			return FindBound(medium, endCoord, arr, approchSide, isFound); ;
			//	}
			//}
		}
	}
}
