namespace CountSymbols
{
    class Task
    {
        static void Main()
        {
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            foreach(char ch in input)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}