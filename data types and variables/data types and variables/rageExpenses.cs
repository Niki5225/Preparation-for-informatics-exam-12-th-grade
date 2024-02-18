namespace Task
{
    class Task
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int keyboardBrokeCount = 0;
            double totalCost = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 6 == 0)
                {
                    totalCost += headsetPrice + keyboardPrice + mousePrice;
                    keyboardBrokeCount++;

                    if (keyboardBrokeCount % 2 == 0 && keyboardBrokeCount != 0)
                    {
                        totalCost += displayPrice;
                    }
                } else if (i % 3 == 0)
                {
                    totalCost += mousePrice;
                } else if (i % 2 == 0)
                {
                    totalCost += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
        }
    }
}