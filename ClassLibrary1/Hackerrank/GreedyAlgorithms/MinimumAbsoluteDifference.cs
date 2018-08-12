using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicPractice.Hackerrank.GreedyAlgorithms
{
    public class MinimumAbsoluteDifference
    {
        static public int minimumAbsoluteDifference(int[] arr)
        {
            var sortedArr = arr.OrderBy(i => i).ToArray();

            int minDiff = int.MaxValue;
            for (int i = 1; i < sortedArr.Length; i++)
            {
                var currentMinDiff = Math.Abs(sortedArr[i] - sortedArr[i - 1]);
                if (currentMinDiff < minDiff)
                    minDiff = currentMinDiff;
            }
            return minDiff;
        }
    }
}
