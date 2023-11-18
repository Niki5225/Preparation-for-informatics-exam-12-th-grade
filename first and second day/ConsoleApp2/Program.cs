namespace task;

public class Task
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue; 
        int maxNumber = int.MinValue;


        for (int i = 0; i < number; i++) { 
            int currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber < minNumber)
            {
                minNumber = currentNumber;
            }

            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }

        Console.WriteLine($"Max number: {maxNumber}");
        Console.WriteLine($"Min number: {minNumber}");

    }
}