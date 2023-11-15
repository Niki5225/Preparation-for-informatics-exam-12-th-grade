public class Task
{
    public static void Main(string[] args)
    {
        int groupsOfClimbers = int.Parse(Console.ReadLine());
        double Musala = 0;
        double K2 = 0;
        double Everest = 0;
        double Monblan = 0;
        double Kilimandjaro = 0;
        double totalClimbers = 0;

        for (int i = 0; i < groupsOfClimbers; i++)
        {
            int currentGroup = int.Parse(Console.ReadLine());
            totalClimbers += currentGroup;
            
            if (currentGroup < 6)
            {
                Musala += currentGroup;
            } else if (currentGroup <= 12) {
                Monblan += currentGroup;
            } else if (currentGroup <= 25)
            {
                Kilimandjaro += currentGroup;
            } else if (currentGroup <= 40)
            {
                K2 += currentGroup;
            } else
            {
                Everest += currentGroup;
            }
        }
        double MusalaPercentage = (Musala / totalClimbers) * 100;
        double K2Percentage = (K2 / totalClimbers) * 100;
        double EverestPercentage = (Everest / totalClimbers) * 100;
        double MonblanPercentage = (Monblan / totalClimbers) * 100;
        double KilimandjaroPercentage = (Kilimandjaro / totalClimbers) * 100;

        Console.WriteLine($"{MusalaPercentage:f2}%");
        Console.WriteLine($"{MonblanPercentage:f2}%");
        Console.WriteLine($"{KilimandjaroPercentage:f2}%");
        Console.WriteLine($"{K2Percentage:f2}%");
        Console.WriteLine($"{EverestPercentage:f2}%");
    }
}