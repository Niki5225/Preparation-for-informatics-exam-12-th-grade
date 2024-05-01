namespace CountCharInAString
{
    class Task
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();   

            foreach(var element in str)
            {
                if (!char.IsWhiteSpace(element))
                {
                    if (dict.ContainsKey(element))
                    {
                        dict[element]++;
                    } else
                    {
                        dict[element] = 1;
                    }
                }
            }

            foreach(var key in dict.Keys)
            {
                Console.WriteLine($"{key} -> {dict[key]}");
            }
        }
    }
}