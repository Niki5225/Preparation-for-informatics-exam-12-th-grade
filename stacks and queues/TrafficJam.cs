namespace TrafficJam
{
    class Task
    {
        static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{carsPassed} cars passed the crossroads.");

                } else if (command == "green")
                {
                    if (greenLightDuration > cars.Count)
                    {
                        while (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsPassed++;
                        }
                    } else 
                    {
                        for (int i = 0; i < greenLightDuration; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                }

                string car = command;
                cars.Enqueue(car);
            }
        }
    }
}