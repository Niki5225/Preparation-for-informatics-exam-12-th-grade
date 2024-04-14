using System.Linq;

namespace TopIntegers
{
    public class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topIntegers = { };

            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                bool isBiggerThanAllNums = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (number <= arr[j])
                    {
                        isBiggerThanAllNums = false;
                    }
                }
                if (isBiggerThanAllNums)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}