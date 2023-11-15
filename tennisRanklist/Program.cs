public class Task
{
    public static void Main(string[] args)
    {
        int tournaments = int.Parse(Console.ReadLine());
        int points = int.Parse(Console.ReadLine());

        int wonTournaments = 0;

        for (int i = 0; i < tournaments; i++) { 
            string currentTournament = Console.ReadLine();

            switch (currentTournament)
            {
                case "W":
                    wonTournaments++;
                    points += 2000;
                    break;
                case "F":
                    points += 1200;
                    break;
                case "SF":
                    points += 720;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        double averagePointsPerTournament = points / wonTournaments;
        double percentageWonTournaments = (wonTournaments / tournaments) * 100;

        Console.WriteLine($"Final points: {points}");
        Console.WriteLine($"Average points: {Math.Ceiling(averagePointsPerTournament)}");
        Console.WriteLine($"{percentageWonTournaments}%");

    }
}