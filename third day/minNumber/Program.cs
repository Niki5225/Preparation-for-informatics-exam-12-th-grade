public class Task
{
    public static void Main(string[] args)
    {
        int minNumber = int.MaxValue;

        string command = Console.ReadLine();

        while (command != "Stop")
        {
            int number = int.Parse(command);
            if (number < minNumber)
            {
                minNumber = number;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(minNumber);
    }
}