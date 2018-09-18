using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Challenges.DecodingMaster
{
	public class Solution
	{
		public int solution(int[] A, int[] B)
		{
			var tilesQty = new Dictionary<int, TilesQty>();
			for(int i = 0; i < A.Length; i++)
			{
				if (A[i] == B[i])
				{
					if (tilesQty.ContainsKey(A[i]))
						tilesQty[A[i]].doubles++;
					else
						tilesQty.Add(A[i], new TilesQty() { doubles = 1, single = 0 });
				}
				else
				{
					if (tilesQty.ContainsKey(A[i]))
						tilesQty[A[i]].single++;
					else
						tilesQty.Add(A[i], new TilesQty() { doubles = 0, single = 1 });

					if (tilesQty.ContainsKey(B[i]))
						tilesQty[B[i]].single++;
					else
						tilesQty.Add(B[i], new TilesQty() { doubles = 0, single = 1 });
				}
			}

			int maxSequence = 0;
			for(int i = 0; i < 7; i++)
			{
				if(tilesQty.ContainsKey(i))
				{
					var t = tilesQty[i];
					var singleQty = t.single > 2 ? 2 : t.single;
					var localMaxSequence = t.doubles * 2 + singleQty;
					if (localMaxSequence > maxSequence)
					{
						maxSequence = localMaxSequence;
					}
				}
			}

			return maxSequence;
		}

		class TilesQty
		{
			public int doubles { get; set; }

			public int single { get; set; }
		}

	}
}
