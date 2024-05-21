using System.ComponentModel;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < lines; i++)
            {
                string[] carData = Console.ReadLine().Split().ToArray();

                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);

                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];

                double tire1Pressure = double.Parse(carData[5]);
                int tire1Age = int.Parse(carData[6]);
                double tire2Pressure = double.Parse(carData[7]);
                int tire2Age = int.Parse(carData[8]);

                double tire3Pressure = double.Parse(carData[9]);
                int tire3Age = int.Parse(carData[10]);

                double tire4Pressure = double.Parse(carData[11]);
                int tire4Age = int.Parse(carData[12]);


                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);

                List<Tire> tires = new List<Tire> { tire1, tire2, tire3, tire4 };

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string cargoTypeToPrint = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (cargoTypeToPrint == "fragile")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == cargoTypeToPrint && CheckFragileCarsTires(car))
                    {
                        resultCars.Add(car);
                    }
                }
            }
            else
            {
                foreach(Car car in cars)
                {
                    if (car.Cargo.Type == "flammable" && CheckFlamableCarEngine(car))
                    {
                        resultCars.Add(car);
                    }
                }
            }

            foreach(Car car in resultCars)
            {
                Console.WriteLine(car.Model);
            }
        }

        static bool CheckFragileCarsTires(Car car)
        {
            int counter = 0;

            foreach (Tire tire in car.TireList)
            {
                if (tire.Pressure < 1)
                {
                    counter++;
                }
            }

            if (counter >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckFlamableCarEngine(Car car)
        {
            if (car.Engine.Power > 250)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}