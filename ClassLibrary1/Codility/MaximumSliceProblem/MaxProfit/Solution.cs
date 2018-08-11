using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.MaximumSliceProblem.MaxProfit
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            int absMin = A[0];
            int maxAfterMinUpdated = A[0];
            int maxProfit = 0;
            for(int i = 1; i < A.Length;i++)
            {
                if(A[i] < absMin)
                {
                    absMin = A[i];
                    maxAfterMinUpdated = A[i];
                }

                if (A[i] > maxAfterMinUpdated)
                    maxAfterMinUpdated = A[i];

                if (maxProfit < maxAfterMinUpdated - absMin)
                    maxProfit = maxAfterMinUpdated - absMin;
            }

            return maxProfit;
        }
    }
}

