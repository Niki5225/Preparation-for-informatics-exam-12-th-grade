namespace WordSynonyms
{
    class Task
    {
        static void Main()
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for(int i = 0; i < numberOfWords; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (dict.ContainsKey(key))
                {
                    dict[key].Add(value);
                } else
                {
                    List<string> lst = new List<string>();
                    lst.Add(value);
                    dict[key] = lst;
                }
            }

            foreach(string key in dict.Keys)
            {
                Console.WriteLine($"{key} - {string.Join(", ", dict[key])}");
            }
        }
    }
}