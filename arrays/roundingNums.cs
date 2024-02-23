using System;
using System.Linq;

namespace Task
{
    class Task
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int roundedNum = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundedNum}");
            }
        }
    }
}