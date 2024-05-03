namespace ReplaceRepeatingChars
{
    class Task
    {
        static void Main()
        {
            List<char> str = Console.ReadLine().ToList();

            for(int i = 0; i < str.Count - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    str.RemoveAt(i + 1);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", str));
        }
    }
}