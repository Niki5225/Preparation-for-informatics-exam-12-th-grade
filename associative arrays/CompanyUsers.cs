namespace CompanyUsers
{
    class Task
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] data = command.Split(" -> ");
                string company = data[0];
                string id = data[1];

                if (dict.ContainsKey(company))
                {
                    if (dict[company].Contains(id))
                    {
                        continue;
                    }

                    dict[company].Add(id);
                } else
                {
                    dict[company] = new List<string>() { id };
                }

               
            }

            foreach(var item in dict)
            {
                Console.WriteLine(item.Key);
                foreach (var employeeId in item.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}