namespace Task
{
    class Task
    {
        static void Main()
        {
            double totalSum = 0;
            int orders = int.Parse(Console.ReadLine());

            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double coffeePrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalSum += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
            }

            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
