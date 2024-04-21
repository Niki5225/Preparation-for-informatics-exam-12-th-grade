namespace HouseParty
{
    class task
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands.Length == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    } else
                    {
                        guests.Add(name);
                    }
                } else if (commands.Length == 4)
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    } else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach(string guest in guests) 
            {
                Console.WriteLine(guest);
            }
        }
    }
}