namespace greening;

public class Greeining
{
    static void Main(string[] args)
    {
        double sumToPay = 0;

        const double squareMeterPrice = 7.61;
        const double discountPercentage = 0.18;

        int metersToBeGreened = int.Parse(Console.ReadLine());


        sumToPay += squareMeterPrice * metersToBeGreened;
        double discount = sumToPay * discountPercentage;
        sumToPay -= discount;

        Console.WriteLine($"The final price is: {sumToPay} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");

    }
}