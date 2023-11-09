namespace afternoonBreak;

public class AfternoonBreakfast
{
    public static void Main(string[] args)
    {
        string series = Console.ReadLine();
        double episodeLength = double.Parse(Console.ReadLine());
        double breakLength = double.Parse(Console.ReadLine());

        double remainingBreak = breakLength - ((1.0 / 8.0 * breakLength) + (1.0 / 4.0 * breakLength));
        remainingBreak -= episodeLength;

        if (remainingBreak >= 0.0)
        {
            Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(remainingBreak)} minutes free time.");
        } else
        {
            Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(Math.Abs(remainingBreak))} more minutes.");
        }
    }
}