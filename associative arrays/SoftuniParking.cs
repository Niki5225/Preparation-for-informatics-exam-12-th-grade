namespace SoftuniParking
{
    class Task
    {
        static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for(int i = 0; i < commands; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string command = data[0];
                string name = data[1];

                if (command == "register")
                {
                    string plate = data[2];
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[name]}");
                    } else
                    {
                        dict[name] = plate;
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                } else
                {
                    if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}