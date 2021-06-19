using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Sample Input
///3
///11 2 4
///4 5 6
///10 8 - 12
/// OutPut
/// 15
/// </summary>

namespace HackerRankTutorial.Easy
{
    public class DiagonalDifferenceExp
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var diag1 = 0;
            var diag2 = 0;
            var arrCount = arr.Count();
            for (var i = 0; i < arrCount; i++)
            {
                diag1 += arr[i][i];
                diag2 += arr[i][arrCount - (i + 1)];
            }

            return Math.Abs(diag2 - diag1);
        }
        public static void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference(arr);

        }
    }
}
