using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.PrimeAndCompositeNumbers.CountFactors
{
    public class Solution
    {
        public int solution(int N)
        {
            int res = 0;
            var sqrtN = Math.Sqrt(N);
            for (int i = 1; i <= sqrtN; i++)
            {
                if (N % i == 0)
                {
                    if (i == sqrtN)
                        res += 1;
                    else
                        res += 2;
                }
            }

            return res;
        }
    }
}
