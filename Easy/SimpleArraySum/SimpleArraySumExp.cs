using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankTutorial.Easy
{
    public class SimpleArraySumExp
    {
        public static int simpleArraySum(List<int> ar)
        {
            var sumArray = 0;
            for (var i = 0; i < ar.Count(); i++)
            {
                sumArray += ar[i];
            }
            return sumArray;

        }

        public static void Result()
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int result = simpleArraySum(ar);
            Console.WriteLine(result);
        }

    }
}
