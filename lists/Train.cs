namespace Train
{
    class Task
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();    
                if(command == "end")
                {
                    break;
                }

                string[] data = command.Split(" ");
                string action = data[0];

                if (action == "Add")
                {
                    int numberOfPassengers = int.Parse(data[1]);
                    wagons.Add(numberOfPassengers);
                } else
                {
                    int numberOfPassengers = int.Parse(data[0]);
                    
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];

                        if(currentWagon + numberOfPassengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += numberOfPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}