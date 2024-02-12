namespace Task;

public class Task
{
    public static void Main(string[] args)
    {
        int numOfOddNums = int.Parse(Console.ReadLine());
        int totalSum = 0;

        for(int i = 1; i <= numOfOddNums * 2; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
                totalSum += i;
            }
        }

        Console.WriteLine($"Sum: {totalSum}");
    }
}