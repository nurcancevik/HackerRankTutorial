using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Sample Input
/// 5
///1000000001 1000000002 1000000003 1000000004 1000000005
///OutPut
///5000000015
/// </summary>
namespace HackerRankTutorial.Easy
{
    public class AVeryBigSumExp
    {
        public static long AVeryBigSum(List<long> ar)
        {
            long sumArray = 0;
            for (var i = 0; i < ar.Count(); i++)
            {
                sumArray += ar[i];
            }
            return sumArray;
        }
        public static void Result()
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            long result = AVeryBigSum(ar);
            Console.WriteLine(result);

        }
    }
}
