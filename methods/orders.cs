namespace Orders
{
    class Task
    {
        const double coffeePrice = 1.5;
        const double waterPrice = 1.00;
        const double cokePrice = 1.40;
        const double snacksPrice = 2.00;


        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());   

            Orders(product, quantity);
        }

        private static void Orders(string product, int quantity)
        {
            switch(product)
            {
                case "coffee":
                    Console.WriteLine($"{(coffeePrice * quantity):F2}");
                    break;
                case "water":
                    Console.WriteLine($"{(waterPrice * quantity):F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(cokePrice * quantity):F2}");    
                    break;
                case "snacks":
                    Console.WriteLine($"{(snacksPrice * quantity):F2}");
                    break;
            }

        }
    }
}