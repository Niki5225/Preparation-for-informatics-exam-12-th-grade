namespace OddOccurences
{
    class Task
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split().ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] result = { };

            foreach (string str in list) 
            {
                string currentStr = str.ToLower();

                if (dict.ContainsKey(currentStr))
                {
                    dict[currentStr]++;
                } else
                {
                    dict[currentStr] = 1;
                }
            }

            foreach(var item in dict)
            {
                if(item.Value % 2 != 0)
                {
                    
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}