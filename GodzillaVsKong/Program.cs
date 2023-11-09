namespace GodzillaVsKong;

public class GodzillaVsKong
{
    public static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int numberOfStatists = int.Parse(Console.ReadLine());
        double priceOutfitPerStatist = double.Parse(Console.ReadLine());

        double decoration = budget * 0.1;
        double discount = 0.0;

        if (numberOfStatists > 150)
        {
            discount = 0.1;
        }

        double neededMoney = decoration + ((priceOutfitPerStatist * numberOfStatists) - (priceOutfitPerStatist * numberOfStatists) * discount);

        budget -= neededMoney;

        if (budget >= 0)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {budget.ToString():f2} leva left.");
        } else
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {Math.Abs(budget):f2} leva more.");
        }

    }
}