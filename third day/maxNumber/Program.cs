public class Task
{
    public static void Main(string[] args)
    {
        int maxNumber = int.MinValue;

        string command = Console.ReadLine();

        while (command != "Stop")
        {
            int number = int.Parse(command);
            if (number > maxNumber)
            {
                maxNumber = number;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(maxNumber);
    }
}