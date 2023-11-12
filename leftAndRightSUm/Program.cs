namespace task;

public class Task
{
    public static void Main(string[] args)
    {
        int numsForSides = int.Parse(Console.ReadLine());

        int leftSide = 0;
        int rightSide = 0;

        for (int i = 0; i < numsForSides; i++)
        {
            leftSide += int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numsForSides; i++)
        {
            rightSide += int.Parse(Console.ReadLine());
        }

        if (leftSide == rightSide) {
            Console.WriteLine($"Yes, sum = {leftSide}");
        } else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSide - rightSide)}");
        }
    }
}