namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            SportsCar sportsCar = new SportsCar(horsePower, fuel);

            sportsCar.Drive(5);
            Console.WriteLine(sportsCar.HorsePower);
            Console.WriteLine(sportsCar.Fuel);
            Console.WriteLine(sportsCar.FuelConsumption);
        }
    }
}