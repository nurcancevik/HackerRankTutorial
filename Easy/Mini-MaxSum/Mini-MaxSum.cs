using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTutorial.Easy
{
    public class Mini_MaxSum
    {
        public static void MiniMaxSum(List<int> arr)
        {
            arr.Sort();
            decimal minSum = 0;
            decimal maxSum = 0;
            for (var i = 0; i < arr.Count() - 1; i++)
            {
                minSum += arr[i];
                maxSum += arr[arr.Count() - 1 - i];
            }
            Console.WriteLine($"{minSum} {maxSum}");

        }
        public static void Result()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            MiniMaxSum(arr);
        }
    }
}
