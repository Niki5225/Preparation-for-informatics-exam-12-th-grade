namespace Task
{
    class Task
    {
        static void Main()
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int neededLightSabersToBuy = (int)Math.Ceiling(students * 1.1);
            int freeBelts = students / 6;
            int neededBeltsToBuy = students - freeBelts;
            double neededMoney = calculateNeededMoney();

            if (neededMoney <= moneyAvailable)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(moneyAvailable - neededMoney):F2}lv more.");

            }

            double calculateNeededMoney()
            {
                double sum = (lightSaberPrice * neededLightSabersToBuy) + (robePrice * students) + (beltPrice * neededBeltsToBuy);

                return sum;
            }
        }
    }
}