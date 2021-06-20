

using System;
using System.Collections.Generic;

namespace HackerRankTutorial.Easy
{
    public class GradingStudentsExp
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            List<int> newGradeList = new List<int>();
            int roundingNumber = 0;
            for (var i = 0; i < grades.Count; i++)
            {
                roundingNumber = grades[i] + (5 - grades[i] % 5);
                if (grades[i] < 38) newGradeList.Add(grades[i]);
                else if (roundingNumber - grades[i] < 3) newGradeList.Add(roundingNumber);
                else newGradeList.Add(grades[i]);
            }
            return newGradeList;
        }

        public static void Result()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}
