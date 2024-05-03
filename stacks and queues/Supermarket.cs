namespace Supermarket
{
    class Task
    {
        static void Main()
        {
            Queue<string> clients = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();   
                if (command == "Paid")
                {
                    foreach(string s in clients)
                    {
                        Console.WriteLine(s);
                    }
                    clients = new Queue<string>();
                    continue;
                } else if (command == "End")
                {
                    Console.WriteLine($"{clients.Count()} people remaining.");
                    break;
                }

                string client = command;
                clients.Enqueue(client);

            }
        }
    }
}