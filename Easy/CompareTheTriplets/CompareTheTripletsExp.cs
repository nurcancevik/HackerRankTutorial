using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTutorial.Easy
{
    public class CompareTheTripletsExp
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var aComp = 0;
            var bComp = 0;
            List<int> compList = new List<int>();
            for (var i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    aComp += 1;
                }
                else if (a[i] < b[i])
                {
                    bComp += 1;
                }
            }
            compList.Add(aComp);
            compList.Add(bComp);
            return compList;

        }
        public static void Result()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = CompareTriplets(a, b);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
