using System;

namespace Task
{
    class Task
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            string[] reversedArr = arr.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}