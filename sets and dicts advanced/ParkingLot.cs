namespace ParkingLot
{
    class Task
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] data = line.Split(",");
                string action = data[0];
                string plate = data[1];

                if (action == "IN") 
                {
                    cars.Add(plate);
                } else
                {
                    cars.Remove(plate);
                }
            }

            if (cars.Count != 0)
            {
                foreach(string s in cars)
                {
                    Console.WriteLine(s);
                }
            } else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}