using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Codility.Leader.Dominator
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;

            int size = 1;
            int val = A[0];
            for(int i = 1; i < A.Length; i++)
            {
                if(size == 0)
                {
                    val = A[i];
                    size = 1;
                }
                else
                {
                    if(A[i] == val)
                    {
                        size++;
                    }
                    else
                    {
                        size--;
                    }
                }
            }

            int candidate;
            if (size > 0)
                candidate = val;
            else
                return -1;

            int cnt = 0;
            int pointer = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    cnt++;
                    pointer = i;
                }
            }

            if (cnt > A.Length / 2)
                return pointer;
            else
                return -1;
        }
    }
}
