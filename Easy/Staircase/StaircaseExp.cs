using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTutorial.Easy
{
    public class StaircaseExp
    {
        public static void Staircase(int n)
        {
            string stairStr = "";
            for (var i = 1; i <= n; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    stairStr = stairStr + "#";
                }

                if (i != n)
                {
                    stairStr = stairStr + ",";
                }
            }
            var stairList = stairStr.Split(',');

            for (var i = 0; i < stairList.Length; i++)
            {
                Console.WriteLine(Convert.ToString(stairList[i]).PadLeft(stairList.Length));
            }
        }
        public static void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Staircase(n);
        }
    }
}
