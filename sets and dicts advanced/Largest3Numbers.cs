using System.Linq;

namespace Largest3Numbers
{
    class Task
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderByDescending(n => n).ToArray(); 

            for(int i = 0; i < Math.Min(3, numbers.Length); i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}