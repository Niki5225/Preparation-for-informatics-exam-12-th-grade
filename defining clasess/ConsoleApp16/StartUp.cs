namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            // Car car = new Car();

            //car.Make = "BMW";
            //car.Model = "X5";
            //car.Year = 2019;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;

            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());


            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());


            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);


            //var tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3)
            //};

            //var engine = new Engine(560, 6300);
            //var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            List<Tire> listTires = new List<Tire>();
            List<Engine> engines = new List<Engine>();

            Dictionary<int, List<Tire>> tiresIndexed = new Dictionary<int, List<Tire>>(); 


            while (true)
            {
                string command = Console.ReadLine();

                if(command == "No more tires")
                {
                    break;
                }

                string[] tires = command.Split().ToArray();

                for (int i = 0; i < tires.Length - 1; i++)
                {
                    int tireYear = int.Parse(tires[i]);
                    double tirePressure = double.Parse(tires[i + 1]);

                    Tire tire = new Tire(tireYear, tirePressure);

                    listTires.Add(tire);

                }
                
            };

            int countKey = 1;

            for(int i = 0; i < listTires.Count; i++)
            {
                if (tiresIndexed.ContainsKey(countKey))
                {
                    if(tiresIndexed[countKey].Count == 4)
                    {
                        countKey++;
                        tiresIndexed[countKey] = new List<Tire>();
                        tiresIndexed[countKey].Add(listTires[i]);
                    } else
                    {
                        tiresIndexed[countKey].Add(listTires[i]);
                    }
                } else
                {
                    tiresIndexed[countKey] = new List<Tire>();
                    tiresIndexed[countKey].Add(listTires[i]);

                }
            }

                while (true)
            {
                string command = Console.ReadLine();
                if (command == "Engines done")
                {
                    break;
                }

                string[] data = command.Split().ToArray();
                Engine engine = new Engine(int.Parse(data[0]), double.Parse(data[1]));

                engines.Add(engine);
            };

            while(true)
            {
                string command = Console.ReadLine();
                if (command == "Show Special")
                {
                    break;
                }


            }
        }
    }
}
