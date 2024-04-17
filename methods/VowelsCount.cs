using System.Collections.Generic;
using System.Linq;

namespace VowelsCount
{
    class Task
    {
        static void Main()
        {
            char[] str = Console.ReadLine().ToCharArray();
            int vowelsCount = GetVowelsCount(str);

            Console.WriteLine(vowelsCount);

        }

        static int GetVowelsCount(char[] arr)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            int vowelsCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (vowels.Contains(char.ToLower(arr[i])))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}