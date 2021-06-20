using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTutorial.Easy
{
    public class TimeConversionExp
    {
        public static string TimeConversion(string s)
        {
            bool isPM = s.Contains("PM");
            var timeString = s.Remove(8).Split(':');
            bool isTwelve = timeString[0] == "12";
            var newTime = "";


            for (var i = 0; i < timeString.Count(); i++)
            {
                if (isPM)
                {
                    if (!isTwelve)
                    {
                        timeString[0] = (Convert.ToInt32(timeString[0]) + 12).ToString();
                    }

                }
                if (!isPM)
                {
                    if (isTwelve)
                    {
                        timeString[0] = "00";
                    }
                }
                newTime += timeString[i] + (i != (timeString.Count()-1) ? ":" : "");

            }
            return newTime;

        }
        public static void Result()
        {
            string s = Console.ReadLine();
            string result = TimeConversion(s);
            Console.WriteLine(result);
        }
    }
}
