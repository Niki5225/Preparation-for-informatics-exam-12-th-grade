namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            string name = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());
            double grams = double.Parse(Console.ReadLine());
            int calories = int.Parse(Console.ReadLine());
            Cake cake = new Cake(name);

            Console.WriteLine(cake.Grams);
        }
    }
}