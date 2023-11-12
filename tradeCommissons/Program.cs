namespace TradeCommissions;

public class TradeCommissions
{
    public static void Main(string[] args)
    {
        string town = Console.ReadLine();
        double volumeOfSales = double.Parse(Console.ReadLine());

        double percentage = 0.00;

        switch (town)
        {
            case "Plovdiv":
                if (0 <= volumeOfSales && volumeOfSales <= 500)
                {
                    percentage = 0.055;
                } else if (500 < volumeOfSales && volumeOfSales <= 1000)
                {
                    percentage = 0.08;
                } else if (1000 < volumeOfSales && volumeOfSales <= 10000)
                {
                    percentage = 0.12;
                } else if (volumeOfSales > 10000)
                {
                    percentage = 0.145;
                } else
                {
                    Console.WriteLine("error");
                }
                break;
            case "Sofia":
                if (0 <= volumeOfSales && volumeOfSales <= 500)
                {
                    percentage = 0.045;
                }
                else if (500 < volumeOfSales && volumeOfSales <= 1000)
                {
                    percentage = 0.075;
                }
                else if (1000 < volumeOfSales && volumeOfSales <= 10000)
                {
                    percentage = 0.1;
                }
                else if (volumeOfSales > 10000)
                {
                    percentage = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "Varna":
                if (0 <= volumeOfSales && volumeOfSales <= 500)
                {
                    percentage = 0.045;
                }
                else if (500 < volumeOfSales && volumeOfSales <= 1000)
                {
                    percentage = 0.075;
                }
                else if (1000 < volumeOfSales && volumeOfSales <= 10000)
                {
                    percentage = 0.1;
                }
                else if (volumeOfSales > 10000)
                {
                    percentage = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            default:
                Console.WriteLine("error");
                break;

        }

        Console.WriteLine($"{(volumeOfSales * percentage):f2}");
    }
}