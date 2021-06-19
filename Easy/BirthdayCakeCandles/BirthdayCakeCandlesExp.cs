using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTutorial.Easy
{
    public class BirthdayCakeCandlesExp
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            var highCount = 0;
            for (var i = 0; i < candles.Count(); i++)
            {
                if (candles[i] == candles[candles.Count() - 1])
                {
                    highCount++;
                }
            }
            return highCount;
        }
        public static void Result()
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
            int result = BirthdayCakeCandles(candles);
            Console.WriteLine(result);
        }
    }
}
