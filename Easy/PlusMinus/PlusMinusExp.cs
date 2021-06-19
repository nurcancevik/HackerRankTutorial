using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTutorial.Easy
{
    public class PlusMinusExp
    {
        public static void PlusMinus(List<int> arr)
        {
            decimal plusNumberCount = 0;
            decimal minusNumberCount = 0;
            decimal zeroNumberCount = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    minusNumberCount++;
                }
                else if (arr[i] > 0)
                {
                    plusNumberCount++;
                }
                else
                {
                    zeroNumberCount++;
                }
            }
            Console.WriteLine(string.Format("{0:N6}", Decimal.Round(plusNumberCount / arr.Count, 6)));
            Console.WriteLine(string.Format("{0:N6}", Decimal.Round(minusNumberCount / arr.Count, 6)));
            Console.WriteLine(string.Format("{0:N6}", Decimal.Round(zeroNumberCount / arr.Count, 6)));

        }
        public static void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus(arr);
        }
    }
}
