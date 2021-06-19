using System;

namespace HackerRankTutorial
{
    public class SolveMeFirstExp
    {
        public static int SolveMeFirst(int a, int b)
        {
            return a + b;

        }

        public static void Result()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }
    }
}
