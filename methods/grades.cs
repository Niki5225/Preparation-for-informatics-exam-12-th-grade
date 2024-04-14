﻿namespace Grades
{
    class Task
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            GradeMethod(grade);
        }

        private static void GradeMethod(double grade)
        {
            if (grade <= 2.99)
            {
                Console.WriteLine("Fail");
            } else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            } else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            } else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            } else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}