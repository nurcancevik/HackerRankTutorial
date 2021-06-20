using System;

using System.Numerics;

namespace HackerRankTutorial.Medium
{
    public class ExtraLongFactorialsExp
    {
        public static void ExtraLongFactorials(int n)
        {
            BigInteger factorial = 1; // 45 in faktöriyeli decimal ı da geçiyordu. O yüzden bigint kullanmamız gerekti
            if (n != 0)
            {
                for (var i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }
            }
            else factorial = 0;
            Console.WriteLine(factorial);

        }
        public static void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            ExtraLongFactorials(n);
        }
    }
}
