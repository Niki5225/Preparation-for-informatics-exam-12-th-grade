using System.Linq;

public class Task
{
    public static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int apartmentsPerFloor = int.Parse(Console.ReadLine());

        for (int i = floors; i > 0; i--)
        {
            string letter = "";

            if (i == floors)
            {
                letter = "L";
            } else if (i % 2 == 0)
            {
                letter = "O";
            } else if (i % 2 != 0)
            {
                letter = "A";
            }

            for (int j = 0; j < apartmentsPerFloor; j++)
            {
                Console.Write($"{letter}{i}{j} ");
            }
            Console.WriteLine();
        }
    }
}