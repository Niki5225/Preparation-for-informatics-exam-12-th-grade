namespace RepeatStrings
{
    class Task
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split().ToArray();

            foreach (string s in strings)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s);
                }
            }
        }
    }
}