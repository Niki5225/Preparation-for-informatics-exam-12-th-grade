namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int linesCars = int.Parse(Console.ReadLine());

            List<Car> listCars = new List<Car>();

            for (int i = 0; i < linesCars; i++)
            {
                string[] carData = Console.ReadLine().Split().ToArray();

                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                listCars.Add(car);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] commandData = command.Split().ToArray();
                string carModel = commandData[1];
                int amountOfKm = int.Parse(commandData[2]);

                Car car = listCars.First(x => x.Model == carModel);

                car.Drive(amountOfKm);
            }

            foreach (Car car in listCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }
    }
}