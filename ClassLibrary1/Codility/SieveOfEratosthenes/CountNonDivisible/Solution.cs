using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.SieveOfEratosthenes.CountNonDivisible
{
    public class Solution
    {
        class Num
        {
            public int NonDevidersCnt { get; set; }

            public int Mult { get; set; }
        }

        public int[] solution(int[] A)
        {
            var res = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < A.Length; j++)
                {
                    if (i != j && A[i] != A[j])
                    {
                        if (A[i] % A[j] != 0)
                        {
                            res[i]++;
                        }
                    }
                }
            }

            return res;
        }
    }
}
