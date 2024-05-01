namespace AMinerTask
{
    class Task
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "stop")
                {
                    break;
                }

                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                } else
                {
                    dict.Add(resource, quantity);
                }
            }

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}