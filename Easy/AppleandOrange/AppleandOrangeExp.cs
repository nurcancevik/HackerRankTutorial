using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTutorial.Easy
{
    public class AppleandOrangeExp
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appCount = 0;
            int orangeCount = 0;

            for (var i = 0; i < apples.Count; i++)
            {
                var appDist = a + apples[i];
                if (s <= appDist && t >= appDist)
                {
                    appCount++;
                }
            }
            for (var i = 0; i < oranges.Count; i++)
            {
                var orangeDist = b + oranges[i];
                if (s <= orangeDist && t >= orangeDist)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine($"{appCount}\n{orangeCount}");
        }

        public static void Result()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

            List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            CountApplesAndOranges(s, t, a, b, apples, oranges);

        }
    }
}
